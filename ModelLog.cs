using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabDev
{
    internal class ModelLog
    {
        public delegate void NotificacaoLogAlterado();
        public event NotificacaoLogAlterado NotificarLogAlterado;

        private string log;

        public ModelLog() 
        {
            log = "Model error log";
        }

        public void ErrorLog(string Error)
        {
            if(Error != null) { 
                log = Error;
                NotificarLogAlterado();
            }
            else
            {
                log = "Algum erro aconteceu na chamada da API do facebook";
            }
        }

        public string GetLog()
        { 
            return log; 
        }

    }
}
