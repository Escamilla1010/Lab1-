using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using MVCPlantilla.Utilerias;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            ViewData["datavideo"] = BaseHelper.ejecutarConsulta("SELECT * FROM VIDEO", CommandType.Text);
            return View();
        }
        public ActionResult Agregar()
        {
            return View();
        }
        public ActionResult Modificar()
        {
            return View();
        }
        public ActionResult Eliminar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(int idVideo,
            string titulo,
            int reproducciones,
            string url)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idvideo", idVideo));
            Parametros.Add(new SqlParameter("@titulo", titulo));
            Parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            Parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("INSERT INTO video VALUES(@idvideo,@titulo,@reproducciones,@url)", CommandType.Text, Parametros);
            return View("Mensaje");
        }

        [HttpPost]
        public ActionResult ModificarVideo(int idVideo,
            string titulo,
            int reproducciones,
            string url)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo", idVideo));
            Parametros.Add(new SqlParameter("@titulo", titulo));
            Parametros.Add(new SqlParameter("@reproducciones", reproducciones));
            Parametros.Add(new SqlParameter("@url", url));
            BaseHelper.ejecutarSentencia("UPDATE Video SET titulo=@titulo,reproducciones=@reproducciones,url=@url WHERE idVideo=@idVideo", CommandType.Text, Parametros);


            return View("Mensaje");
        }
        [HttpPost]
        public ActionResult BorrarVideo(int idVideo)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo", idVideo));
            BaseHelper.ejecutarSentencia("DELETE FROM Video WHERE idVideo = @idVideo", CommandType.Text, Parametros);
            return View("Mensaje");

        }
    }
}
