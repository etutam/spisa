using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using Microsoft.Data.Extensions;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

namespace Gestioname.Infrastructure.Model
{
    public static class GestionameContextCustomExtensions 
    {

        public static void ApplyReferencePropertyChanges(this GestionameContext context, IEntityWithRelationships newEntity, IEntityWithRelationships oldEntity)
        {
            foreach (var relatedEnd in oldEntity.RelationshipManager.GetAllRelatedEnds())
            {

                var oldRef = relatedEnd as EntityReference;

                if (oldRef != null)
                {

                    // this related end is a reference not a collection 

                    var newRef = newEntity.RelationshipManager.GetRelatedEnd(oldRef.RelationshipName, oldRef.TargetRoleName) as EntityReference;

                    oldRef.EntityKey = newRef.EntityKey;

                }
            }
        }

        public static void AttachUpdated(this GestionameContext context, EntityObject objectDetached)
        {

            if (objectDetached.EntityState == EntityState.Detached)
            {

                object currentEntityInDb = null;

                if (context.TryGetObjectByKey(objectDetached.EntityKey, out currentEntityInDb))
                {

                    context.ApplyPropertyChanges(objectDetached.EntityKey.EntitySetName, objectDetached);

                    //(CDLTLL)Apply property changes to all referenced entities in context 

                    context.ApplyReferencePropertyChanges((IEntityWithRelationships)objectDetached,

                                                                                        (IEntityWithRelationships)currentEntityInDb); //Custom extensor method 

                }

                else
                {

                    throw new ObjectNotFoundException();

                }

            }

        }
    }
}
