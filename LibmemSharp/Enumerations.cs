using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibmemSharp
{
    public enum LM_ARCHITECTURES
    {
        LM_ARCH_ARMV7 = 0, /* ARMv7 */
        LM_ARCH_ARMV8,     /* ARMv8 */
        LM_ARCH_THUMBV7,   /* ARMv7, thumb mode */
        LM_ARCH_THUMBV8,   /* ARMv8, thumb mode */
        LM_ARCH_ARMV7EB,   /* ARMv7, big endian */
        LM_ARCH_THUMBV7EB, /* ARMv7, big endian, thumb mode */
        LM_ARCH_ARMV8EB,   /* ARMv8, big endian */
        LM_ARCH_THUMBV8EB, /* ARMv8, big endian, thumb mode */
        LM_ARCH_AARCH64,   /* ARM64/AArch64 */
        LM_ARCH_MIPS,     /* Mips32 */
        LM_ARCH_MIPS64,   /* Mips64 */
        LM_ARCH_MIPSEL,   /* Mips32, little endian */
        LM_ARCH_MIPSEL64, /* Mips64, little endian */
        LM_ARCH_X86_16, /* x86_16 */
        LM_ARCH_X86,    /* x86_32 */
        LM_ARCH_X64,    /* x86_64 */
        LM_ARCH_PPC32,   /* PowerPC 32 */
        LM_ARCH_PPC64,   /* PowerPC 64 */
        LM_ARCH_PPC64LE, /* PowerPC 64, little endian */
        /* SPARC */
        LM_ARCH_SPARC,   /* Sparc */
        LM_ARCH_SPARC64, /* Sparc64 */
        LM_ARCH_SPARCEL, /* Sparc, little endian */
        /* SystemZ */
        LM_ARCH_SYSZ, /* S390X */
        LM_ARCH_MAX
    }
    public enum LM_PROT
    {
        LM_PROT_NONE = 0,
        LM_PROT_R = (1 << 0),
        LM_PROT_W = (1 << 1),
        LM_PROT_X = (1 << 2),
        LM_PROT_XR = LM_PROT_X | LM_PROT_R,
        LM_PROT_XW = LM_PROT_X | LM_PROT_W,
        LM_PROT_RW = LM_PROT_R | LM_PROT_W,
        LM_PROT_XRW = LM_PROT_X | LM_PROT_R | LM_PROT_W
    }
}
