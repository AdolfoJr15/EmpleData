using System.Text;

namespace EmpleData.Funtions
{
    public class GeneralFunction
    {

        public IConfiguration Configuration { get; set; }
        public void Addlog(string newlog)
        {
            string CarpetaLog = AppDomain.CurrentDomain.BaseDirectory + "Logs//";
            if (!Directory.Exists(CarpetaLog))
            {
                Directory.CreateDirectory(CarpetaLog);
            }
            string Ruta = CarpetaLog + AppDomain.CurrentDomain.FriendlyName + "-" + DateTime.Now.ToString("dd-MM-yyyy") + ".log";
            var registro = DateTime.Now + "-" + newlog + "\n";
            var nuevolog = new UTF8Encoding(true).GetBytes(registro);
            using (FileStream log = File.Open(Ruta, FileMode.Append))
            {
                log.Write(nuevolog, 0, nuevolog.Length);
            }
        }
    }
}
