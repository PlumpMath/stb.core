/*---------------------------------------------------------------------------------------------
 * Copyright (c) STB Chain. All rights reserved.
 * Licensed under the Source EULA. See License in the project root for license information.
 * Source code : https://github.com/stbchain
 * Website : http://www.soft2b.com/
 *---------------------------------------------------------------------------------------------
 ---------------------------------------------------------------------------------------------*/

using System;

namespace STB.Core.Structures.Commissions
{
    public class WitnessingOutputs
    {
        public int? MainChainIndex { get; set; }
        public string Address { get; set; }
        public long? Amount { get; set; }
        public byte? IsSpent { get; set; } = 0;
        public DateTime? CreationDate { get; set; } = DateTime.Now;
    }
}