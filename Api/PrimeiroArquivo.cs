namespace CursoCSharp.Api
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string? home = (Environment.OSVersion.Platform == PlatformID.Unix || 
                Environment.OSVersion.Platform == PlatformID.MacOSX)
                ? Environment.GetEnvironmentVariable("HOME")
                : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            return path.Replace("~", home);

        }
    }
    class PrimeiroArquivo
    {        
        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome(); // @ usado pra interpretar como código literal

            if(!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path)) //Cria o arquivo txt
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo !");
                }
            }
            using (StreamWriter sw = File.AppendText(path)) // Adiciona textos como alteração
            {
                sw.WriteLine("");
                sw.WriteLine("É possível adicionar");
                sw.WriteLine("mais texto");
                sw.WriteLine("como alteração !");
            }
        }
    }
}
