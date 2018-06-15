﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Globalization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Net;
using System.Net.Mail;
using System.Xml;

namespace xtremsoft.webmethod
{
  public class Usuario
  {
    private string pCodUsuario = string.Empty;
    public string CodUsuario { get { return pCodUsuario; } set { pCodUsuario = value; } }

    private string pNombres = string.Empty;
    public string Nombres { get { return pNombres; } set { pNombres = value; } }

    private string pTipo = string.Empty;
    public string Tipo { get { return pTipo; } set { pTipo = value; } }

    private string pEmail = string.Empty;
    public string Email { get { return pEmail; } set { pEmail = value; } }

    private string pFono = string.Empty;
    public string Fono { get { return pFono; } set { pFono = value; } }

    private string pImagen = string.Empty;
    public string Imagen { get { return pImagen; } set { pImagen = value; } }

    private string pCodNkey = string.Empty;
    public string CodNkey { get { return pCodNkey; } set { pCodNkey = value; } }

    private string pTipoUsuario = string.Empty;
    public string TipoUsuario { get { return pTipoUsuario; } set { pTipoUsuario = value; } }

    private string pNKeyUsuario = string.Empty;
    public string NKeyUsuario { get { return pNKeyUsuario; } set { pNKeyUsuario = value; } }

    public Usuario()
    {

    }

  }

  public class IndicadorEconomico
  {
    private string pDolarObs = string.Empty;
    public string DolarObs { get { return pDolarObs; } set { pDolarObs = value; } }

    private string pEuro = string.Empty;
    public string Euro { get { return pEuro; } set { pEuro = value; } }

    private string pUF = string.Empty;
    public string UF { get { return pUF; } set { pUF = value; } }

    private string pUTM = string.Empty;
    public string UTM { get { return pUTM; } set { pUTM = value; } }

    public IndicadorEconomico()
    {

    }

  }

  public class Culture
  {
    CultureInfo Cultura;
    public Culture()
    {
      string[] languages = HttpContext.Current.Request.UserLanguages;

      if (languages == null || languages.Length == 0)
      {
        Cultura = new CultureInfo("es-cl");
      }
      try
      {
        string language = languages[0].ToLowerInvariant().Trim();
        Cultura = CultureInfo.CreateSpecificCulture(language);
      }
      catch (Exception e)
      {
        Cultura = new CultureInfo("en-us");
      }

    }
    /// <summary>
    /// Retorna Texto del Recurso
    /// </summary>
    /// <param name="Class">Nombre</param>
    /// <param name="Key">Key</param>
    /// <returns></returns>
    public string GetResource(string sClase, string sKey)
    {
      string sRecurso = string.Empty;

      if (HttpContext.GetGlobalResourceObject(sClase, sKey, Cultura) != null)
        sRecurso = HttpContext.GetGlobalResourceObject(sClase, sKey, Cultura).ToString();
      return sRecurso;
    }

    /// <summary>
    /// Objeto Culture
    /// </summary>
    /// <returns></returns>
    public CultureInfo GetResource()
    {
      return Cultura;
    }
  }

  public class cWeb
  {
    public void GetIndicadoresEconomicos()
    {
      IndicadorEconomico oIndEco = new IndicadorEconomico();
      XmlTextReader oReader = new XmlTextReader("http://indicadoresdeldia.cl/webservice/indicadores.xml");

      XmlDocument oXmlDoc = new XmlDocument();
      oXmlDoc.Load(oReader);

      XmlNodeList oIndicadores = oXmlDoc.GetElementsByTagName("indicadores");
      XmlNodeList oMoneda = ((XmlElement)oIndicadores[0]).GetElementsByTagName("moneda");

      oIndEco.DolarObs = oMoneda[0].ChildNodes[0].Attributes[0].InnerText; //((oMoneda[0] as XmlElement).GetAttribute("valor"));
      oIndEco.Euro = oMoneda[0].ChildNodes[2].Attributes[0].InnerText;  //((oMoneda[2] as XmlElement).GetAttribute("valor"));

      XmlNodeList oIndicador = ((XmlElement)oIndicadores[0]).GetElementsByTagName("indicador");

      oIndEco.UF = oIndicador[0].ChildNodes[1].Attributes[0].InnerText;  //((oIndicador[1] as XmlElement).GetAttribute("valor"));
      oIndEco.UTM = oIndicador[0].ChildNodes[3].Attributes[0].InnerText;  //((oIndicador[3] as XmlElement).GetAttribute("valor"));

      HttpContext.Current.Session["INDICADORESESCONOCMICOS"] = oIndEco;
    }

    public Usuario GetObjUsuario()
    {
      Usuario oIsUsuario;
      if ((HttpContext.Current.Session["USUARIO"] != null) && (!string.IsNullOrEmpty(HttpContext.Current.Session["USUARIO"].ToString())))
      {
        oIsUsuario = (Usuario)HttpContext.Current.Session["USUARIO"];
      }
      else
      {
        oIsUsuario = new Usuario();
      }
      return oIsUsuario;

    }

    public string GetIpUsuario()
    {
      string sIpUsuario = ((HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null) && (!string.IsNullOrEmpty(HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString())) ? HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString() : HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString());
      return sIpUsuario;
    }

    public void ValidaSessionAdm()
    {
      if ((HttpContext.Current.Session["USUARIO"] == null) && (HttpContext.Current.Session["Administrador"] == null) || (string.IsNullOrEmpty(HttpContext.Current.Session["USUARIO"].ToString())) && (string.IsNullOrEmpty(HttpContext.Current.Session["USUARIO"].ToString())))
      {
        HttpContext.Current.Response.Redirect("redirection.htm");
      }
    }

    public Usuario ValidaUserAppReport()
    {
      Usuario oIsUsuario = null;
      if ((HttpContext.Current.Session["USUARIO"] != null))
      {
        oIsUsuario = GetObjUsuario();
        if (string.IsNullOrEmpty(oIsUsuario.CodNkey))
          HttpContext.Current.Response.Redirect("redirection.htm");
      }
      else
      {
        HttpContext.Current.Response.Redirect("redirection.htm");
      }

      return oIsUsuario;
    }

    public string GetData(string sData)
    {
      string sRetorno = String.Empty;

      try
      {
        if (HttpContext.Current.Request.Form.Count != 0)
        {
          sRetorno = Convert.ToString(HttpContext.Current.Request.Form[sData]);
        }
        else if (HttpContext.Current.Request.QueryString.Count != 0)
        {
          sRetorno = Convert.ToString(HttpContext.Current.Request.QueryString[sData]);
        }
        return sRetorno;
      }
      catch { return sRetorno; }
    }

    public string GetSession(string sData)
    {
      string sRetorno = string.Empty;
      if (HttpContext.Current.Session[sData] != null)
        sRetorno = HttpContext.Current.Session[sData].ToString();

      return sRetorno;
    }

    public bool ValidaMail(string sMail)
    {
      bool bSuccess = false;
      Regex r = new Regex("^([\\w-\\.]+)@((\\[[0-9]{1,3}\\.[0-9]{1,3}\\.[0-9]{1,3}\\.)|(([\\w-]+\\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\\]?)$", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline);
      //Regex r = new Regex("/^\\w+([\\.-]?\\w+)*@\\w+([\\.-]?\\w+)*(\\.\\w{2,4})+$/", RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.Multiline);
      bSuccess = r.Match(sMail).Success;

      return bSuccess;
    }

    public DataTable DeserializarTbl(string cPath, string cFile)
    {
      if (!string.IsNullOrEmpty(cPath))
      {

        StringBuilder oFolder = new StringBuilder();
        oFolder.Append(cPath);
        oFolder.Append(@"\binary\");
        if (File.Exists(oFolder.ToString() + cFile))
        {
          IFormatter oBinFormat = new BinaryFormatter();
          Stream oFileStream = new FileStream(oFolder.ToString() + cFile, FileMode.Open, FileAccess.Read, FileShare.Read);
          DataTable oData = (DataTable)oBinFormat.Deserialize(oFileStream);
          oFileStream.Close();
          return oData;
        }
        return new DataTable();
      }
      return new DataTable();
    }

    public byte[] GetImageBytes(Stream stream)
    {
      byte[] buffer;

      using (Bitmap image = ResizeImage(stream))
      {
        using (MemoryStream ms = new MemoryStream())
        {
          image.Save(ms, ImageFormat.Png);

          //return the current position in the stream at the beginning
          ms.Position = 0;

          buffer = new byte[ms.Length];
          ms.Read(buffer, 0, (int)ms.Length);
          return buffer;
        }
      }
    }

    public byte[] GetImageBytes(Stream stream, int height, int width)
    {
      byte[] buffer;

      using (Bitmap image = ResizeImage(stream, height, width))
      {
        using (MemoryStream ms = new MemoryStream())
        {
          image.Save(ms, ImageFormat.Png);

          //return the current position in the stream at the beginning
          ms.Position = 0;

          buffer = new byte[ms.Length];
          ms.Read(buffer, 0, (int)ms.Length);
          return buffer;
        }
      }
    }

    public Bitmap ResizeImage(Stream stream)
    {
      System.Drawing.Image originalImage = Bitmap.FromStream(stream);

      Bitmap scaledImage = new Bitmap(originalImage.Width, originalImage.Height);

      using (Graphics g = Graphics.FromImage(scaledImage))
      {
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        g.DrawImage(originalImage, 0, 0, originalImage.Width, originalImage.Height);

        return scaledImage;
      }

    }

    public Bitmap ResizeImage(Stream stream, int height, int width)
    {

      System.Drawing.Image originalImage = Bitmap.FromStream(stream);

      //int height = 300;
      //int width = 300;

      double ratio = Math.Min(originalImage.Width, originalImage.Height) / (double)Math.Max(originalImage.Width, originalImage.Height);

      if (originalImage.Width > originalImage.Height)
      {
        height = Convert.ToInt32(height * ratio);
      }
      else
      {
        width = Convert.ToInt32(width * ratio);
      }

      Bitmap scaledImage = new Bitmap(width, height);

      using (Graphics g = Graphics.FromImage(scaledImage))
      {
        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
        g.DrawImage(originalImage, 0, 0, width, height);

        return scaledImage;
      }

    }

    #region Encriptar
    /// <summary>
    /// Método para encriptar un texto plano usando el algoritmo (Rijndael).
    /// Este es el mas simple posible, muchos de los datos necesarios los
    /// definimos como constantes.
    /// </summary>
    /// <param name="textoQueEncriptaremos">texto a encriptar</param>
    /// <returns>Texto encriptado</returns>
    public string Crypt(string textoQueEncriptaremos)
    {
      return Crypt(textoQueEncriptaremos, "xtremsoft75dc@avz10", "s@lAvz", "MD5", 1, "@1B2c3D4e5F6g7H8", 128);
    }
    /// <summary>
    /// Método para encriptar un texto plano usando el algoritmo (Rijndael)
    /// </summary>
    /// <returns>Texto encriptado</returns>
    public string Crypt(string textoQueEncriptaremos, string passBase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
    {
      byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
      byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
      byte[] plainTextBytes = Encoding.UTF8.GetBytes(textoQueEncriptaremos);
      PasswordDeriveBytes password = new PasswordDeriveBytes(passBase, saltValueBytes, hashAlgorithm, passwordIterations);
      byte[] keyBytes = password.GetBytes(keySize / 8);
      RijndaelManaged symmetricKey = new RijndaelManaged()
      {
        Mode = CipherMode.CBC
      };
      ICryptoTransform encryptor = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes);
      MemoryStream memoryStream = new MemoryStream();
      CryptoStream cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write);
      cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
      cryptoStream.FlushFinalBlock();
      byte[] cipherTextBytes = memoryStream.ToArray();
      memoryStream.Close();
      cryptoStream.Close();
      string cipherText = Convert.ToBase64String(cipherTextBytes);
      return cipherText;
    }
    #endregion

    #region Desencriptar
    /// <summary>
    /// Método para desencriptar un texto encriptado.
    /// </summary>
    /// <returns>Texto desencriptado</returns>
    public string UnCrypt(string textoEncriptado)
    {
      return UnCrypt(textoEncriptado, "xtremsoft75dc@avz10", "s@lAvz", "MD5", 1, "@1B2c3D4e5F6g7H8", 128);
    }
    /// <summary>
    /// Método para desencriptar un texto encriptado (Rijndael)
    /// </summary>
    /// <returns>Texto desencriptado</returns>
    public string UnCrypt(string textoEncriptado, string passBase, string saltValue, string hashAlgorithm, int passwordIterations, string initVector, int keySize)
    {
      byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
      byte[] saltValueBytes = Encoding.ASCII.GetBytes(saltValue);
      byte[] cipherTextBytes = Convert.FromBase64String(textoEncriptado);
      PasswordDeriveBytes password = new PasswordDeriveBytes(passBase, saltValueBytes, hashAlgorithm, passwordIterations);
      byte[] keyBytes = password.GetBytes(keySize / 8);
      RijndaelManaged symmetricKey = new RijndaelManaged()
      {
        Mode = CipherMode.CBC
      };
      ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
      MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
      CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
      byte[] plainTextBytes = new byte[cipherTextBytes.Length];
      int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
      memoryStream.Close();
      cryptoStream.Close();
      string plainText = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
      return plainText;
    }
    #endregion

  }

  public class Emailing
  {
    private string pFrom;
    public string From { get { return pFrom; } set { pFrom = value; } }

    private string pFromName;
    public string FromName { get { return pFromName; } set { pFromName = value; } }

    private string pAddress;
    public string Address { get { return pAddress; } set { pAddress = value; } }

    private string pSubject;
    public string Subject { get { return pSubject; } set { pSubject = value; } }

    private string pError;
    public string Error { get { return pError; } set { pError = value; } }

    private StringBuilder pBody;
    public StringBuilder Body { get { return pBody; } set { pBody = value; } }

    public bool EmailSend()
    {
      bool bSend = false;
      MailMessage oMail = new MailMessage();
      oMail.IsBodyHtml = true;
      oMail.From = new MailAddress(pAddress, pFromName);
      oMail.To.Add(pAddress);
      oMail.Subject = pSubject;
      oMail.Body = pBody.ToString();
      try
      {
        SmtpClient oStmpClient = new SmtpClient();
        oStmpClient.Host = HttpContext.Current.Application["SmtpServer"].ToString();
        oStmpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
        oStmpClient.UseDefaultCredentials = false;
        if ((HttpContext.Current.Application["PortSmtpServer"] != null) && (!string.IsNullOrEmpty(HttpContext.Current.Application["PortSmtpServer"].ToString())))
          oStmpClient.Port = int.Parse(HttpContext.Current.Application["PortSmtpServer"].ToString());
        if ((HttpContext.Current.Application["UserSmtp"] != null) && (!string.IsNullOrEmpty(HttpContext.Current.Application["UserSmtp"].ToString())))
          oStmpClient.Credentials = new NetworkCredential(HttpContext.Current.Application["UserSmtp"].ToString(), HttpContext.Current.Application["PwdSmtp"].ToString());
        oStmpClient.Send(oMail);
        bSend = true;
      }
      catch (Exception e)
      {
        Error = e.Message;
      }
      return bSend;
    }


  }
}
