using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibmemSharp
{
    public struct lm_process_t
    {
        Int32 pid;
        Int32 ppid;
        LM_ARCHITECTURES arch;
        byte[] bits;
        TimeZone start_time; /* Process start timestamp, in milliseconds since last boot */
        string path;
        string name;
    }
    public struct lm_thread_t
    {
        int tid;
        int ttid;
    }
    public struct lm_module_t
    {
        int base_t;
        int end_t;
        UIntPtr size;
        string path;
        string name;
    }
    public struct lm_segment_t
    {
        Int32 base_t;
        Int32 end_t;
        UIntPtr size;
        LM_PROT[] prot;
    }
    public struct lm_inst_t
    {
        Int32 address;
        UIntPtr size;
        byte[] bytes;
        string[] mnemonic;
        string[] op_str;
    }
    public struct lm_vmt_entry_t
    {
        Int32 orig_func;
        Int32[] index;
    }
    public struct lm_vmt_t
    {
        UIntPtr[] vtable;
        lm_vmt_entry_t[] hkentries;
    }
}
