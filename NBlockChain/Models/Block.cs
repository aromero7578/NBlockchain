﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NBlockChain.Models
{
    public class Block
    {
        public BlockHeader Header { get; set; }        
        public ICollection<TransactionEnvelope> Transactions { get; set; } = new HashSet<TransactionEnvelope>();
        public MerkleNode MerkleRootNode { get; set; }
    }    
}
