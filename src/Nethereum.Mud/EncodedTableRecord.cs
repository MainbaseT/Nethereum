﻿using Nethereum.Mud.EncodingDecoding;

namespace Nethereum.Mud
{
    public class EncodedTableRecord
    {
       public byte[] TableId { get; set; }
       
        public List<byte[]> Key { get; set; }
       public EncodedValues EncodedValues { get; set; }
    }
}
