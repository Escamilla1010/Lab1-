<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Modificar</title>
</head>
<body>
    <form action="/Video/ModificarVideo" method="post">
    <fieldset>
    <legend> Datos del video</legend>

    <label for="idvideo">idvideo:</label>
        <input type="text" name="idvideo" />
        <br />

        <label for="titulo">titulo:</label>
        <input type="text" name="titulo" />
        <br />

        <label for="reproducciones">repro:</label>
        <input type="text" name="reproducciones" />
        <br />

        <label for="url">url:</label>
        <input type="text" name="url" />
        <br />
        <input type="submit" name="modificarVideo" value="Modificar video " />
      </fieldset>
      </form>
</body>
</html>
