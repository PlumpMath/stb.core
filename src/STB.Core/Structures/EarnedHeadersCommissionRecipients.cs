﻿/*---------------------------------------------------------------------------------------------
 * Copyright (c) STB Chain. All rights reserved.
 * Licensed under the Source EULA. See License in the project root for license information.
 * Source code : https://github.com/stbchain
 * Website : http://www.soft2b.com/
 *---------------------------------------------------------------------------------------------
 ---------------------------------------------------------------------------------------------*/

namespace STB.Core.Structures
{
    public class EarnedHeadersCommissionRecipients
    {
        public Unit Unit { get; set; }

        public string Address { get; set; }

        public int EarnedHeadersCommissionShare { get; set; }
    }
}