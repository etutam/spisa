using System;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Reflection;

using Gestioname.Framework.ObjectContextManager;
using Gestioname.Infrastructure.Model;

namespace Gestioname.Infrastructure.BaseClasses
{
    /// <summary>
    /// Generic base class for all other Facade classes.
    /// </summary>
    /// <typeparam name="T">An EntityObject type.</typeparam>
    public abstract class FacadeBase<T> where T : System.Data.Objects.DataClasses.EntityObject
    {
        private ObjectContextManager<GestionameContext> _objectContextManager;

        /// <summary>
        /// Returns the current ObjectContextManager instance. Encapsulated the 
        /// _objectContextManager field to show it as an association on the class diagram.
        /// </summary>
        private ObjectContextManager<GestionameContext> ObjectContextManager
        {
            get { return _objectContextManager; }
            set { _objectContextManager = value; }
        }

        /// <summary>
        /// Returns a NorthwindObjectContext object. 
        /// </summary>
        protected internal GestionameContext ObjectContext
        {
            get
            {
                if (ObjectContextManager == null)
                    this.InstantiateObjectContextManager();

                return ObjectContextManager.ObjectContext;
            }
        }

        /// <summary>
        /// Default constructor.
        /// </summary>
        public FacadeBase()
        { }

        /// <summary>
        /// Instantiates a new ObjectContextManager based on application configuration settings.
        /// </summary>
        private void InstantiateObjectContextManager()
        {
            /* Retrieve ObjectContextManager configuration settings: */
            Hashtable ocManagerConfiguration = ConfigurationManager.GetSection("Northwind.BusinessLayer.Facade.ObjectContext") as Hashtable;
            if (ocManagerConfiguration != null && ocManagerConfiguration.ContainsKey("managerType"))
            {
                string managerTypeName = ocManagerConfiguration["managerType"] as string;
                if (string.IsNullOrEmpty(managerTypeName))
                    throw new ConfigurationErrorsException("The managerType attribute is empty.");
                else
                    managerTypeName = managerTypeName.Trim().ToLower();

                try
                {
                    /* Try to create a type based on it's name: */
                    Assembly frameworkAssembly = Assembly.GetAssembly(typeof(ObjectContextManager<>));
                    /* We have to fix the name, because its a generic class: */
                    Type managerType = frameworkAssembly.GetType(managerTypeName + "`1", true, true);
                    managerType = managerType.MakeGenericType(typeof(GestionameContext));

                    /* Try to create a new instance of the specified ObjectContextManager type: */
                    this.ObjectContextManager = Activator.CreateInstance(managerType) as ObjectContextManager<GestionameContext>;
                }
                catch (Exception e)
                {
                    throw new ConfigurationErrorsException("The managerType specified in the configuration is not valid.", e);
                }
            }
            else
                throw new ConfigurationErrorsException("A Northwind.BusinessLayer.Facade.ObjectContext tag or its managerType attribute is missing in the configuration.");
        }

        /// <summary>
        /// Persists all changes to the underlying datastore.
        /// </summary>
        public void SaveAllObjectChanges()
        {
            this.ObjectContext.SaveChanges();
        }

        /// <summary>
        /// Adds a new entity object to the context.
        /// </summary>
        /// <param name="newObject">A new object.</param>
        public virtual void Add(T newObject)
        {
            this.ObjectContext.AddObject(newObject.GetType().Name, newObject);
        }
        /// <summary>
        /// Deletes an entity object.
        /// </summary>
        /// <param name="obsoleteObject">An obsolete object.</param>
        public virtual void Delete(T obsoleteObject)
        {
            this.ObjectContext.DeleteObject(obsoleteObject);
        }
    }
}
