using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Web;


namespace BolsaDeTrabajo.Models
{
    public class ValidWebSite:ValidationAttribute
    {
        //protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        //{
        //    var perfilProfesional = (PerfilProfesional)validationContext.ObjectInstance;
        //    if (CheckSite(perfilProfesional.SitioWeb))
        //    {
        //        return ValidationResult.Success;
        //    }
        //    return new ValidationResult("No se ha podido confirmar el sitio web");
        //}

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return new ValidationResult("Something went wrong");
        }


        public Boolean CheckSite(String postLocation)
        {
            HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(postLocation);
            // Setting the useragent seems resolves certain issues that *may* crop up depending on the server
            httpRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
            httpRequest.KeepAlive = false;
            httpRequest.Method = "GET";

            using (HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse())
            {
                if (httpResponse.StatusCode != HttpStatusCode.OK)
                {
                    return false;
                }
                return true;
            }
        }
    }
}