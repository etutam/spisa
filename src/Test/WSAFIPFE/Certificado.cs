namespace WSAFIPFE
{
    using Microsoft.VisualBasic.CompilerServices;
    using System;
    using System.Security.Cryptography.Pkcs;
    using System.Security.Cryptography.X509Certificates;
    using WSAFIPFE.My;

    internal class Certificado
    {
        internal static byte[] FirmaBytesMensaje(byte[] argBytesMsg, X509Certificate2 argCertFirmante)
        {
            byte[] FirmaBytesMensaje;
            try
            {
                ContentInfo infoContenido = new ContentInfo(argBytesMsg);
                SignedCms cmsFirmado = new SignedCms(infoContenido);
                CmsSigner cmsFirmante = new CmsSigner(argCertFirmante);
                cmsFirmante.IncludeOption = X509IncludeOption.EndCertOnly;
                cmsFirmado.ComputeSignature(cmsFirmante);
                FirmaBytesMensaje = cmsFirmado.Encode();
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception excepcionAlFirmar = exception1;
                throw new Exception("***Error al firmar: FirmaBytesMensaje: " + excepcionAlFirmar.Message);
            }
            return FirmaBytesMensaje;
        }

        internal static X509Certificate2 ObtieneCertificadoDesdeArchivo(string argArchivo)
        {
            X509Certificate2 ObtieneCertificadoDesdeArchivo;
            X509Certificate2 objCert = new X509Certificate2();
            try
            {
                objCert.Import(MyProject.Computer.FileSystem.ReadAllBytes(argArchivo));
                ObtieneCertificadoDesdeArchivo = objCert;
            }
            catch (Exception exception1)
            {
                ProjectData.SetProjectError(exception1);
                Exception excepcionAlImportarCertificado = exception1;
                throw new Exception("***Error al obtener certificado: ObtieneCertificadoDesdeArchivo(" + argArchivo + "): " + excepcionAlImportarCertificado.Message + " " + excepcionAlImportarCertificado.StackTrace);
            }
            return ObtieneCertificadoDesdeArchivo;
        }
    }
}

