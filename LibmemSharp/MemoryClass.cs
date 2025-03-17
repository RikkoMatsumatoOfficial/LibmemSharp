using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LibmemSharp
{
    public class MemoryClass
    {
        const string l_mem = @"libmem.dll";
        [DllImport(l_mem)]
        public static extern lm_bool_t LM_FindProcess(string process_name, lm_process_t process); //BASS START

        public lm_bool_t OpenProcess(string proc_name, lm_process_t process)
        {
            if(LM_FindProcess(proc_name, process) == lm_bool_t.FALSE)
            {
                return lm_bool_t.FALSE;
            }
            else
            {
                return lm_bool_t.TRUE;
            }
        }
    }
}
