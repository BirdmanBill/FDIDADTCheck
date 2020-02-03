using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirdmanStudio
{
    class DBC
    {
        public struct DBC_Header
        {
            public UInt32 magic; // always 'WDBC'
            public UInt32 record_count; // records per file
            public UInt32 field_count; // fields per record
            public UInt32 record_size; // sum (sizeof (field_type_i)) | 0 <= i < field_count. field_type_i is NOT defined in the files.
            public UInt32 string_block_size;
        }

        public struct DBC_file
        {

        }
    }
}
