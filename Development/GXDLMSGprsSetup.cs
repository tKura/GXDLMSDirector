//
// --------------------------------------------------------------------------
//  Gurux Ltd
// 
//
//
// Filename:        $HeadURL: svn://utopia/projects/GXDLMSDirector/Development/GXDLMSGprsSetup.cs $
//
// Version:         $Revision: 4781 $,
//                  $Date: 2012-03-19 10:23:38 +0200 (ma, 19 maalis 2012) $
//                  $Author: kurumi $
//
// Copyright (c) Gurux Ltd
//
//---------------------------------------------------------------------------
//
//  DESCRIPTION
//
// This file is a part of Gurux Device Framework.
//
// Gurux Device Framework is Open Source software; you can redistribute it
// and/or modify it under the terms of the GNU General Public License 
// as published by the Free Software Foundation; version 2 of the License.
// Gurux Device Framework is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of 
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. 
// See the GNU General Public License for more details.
//
// More information of Gurux DLMS/COSEM Director: http://www.gurux.org/GXDLMSDirector
//
// This code is licensed under the GNU General Public License v2. 
// Full text may be retrieved at http://www.gnu.org/licenses/gpl-2.0.txt
//---------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using System.Text;
using Gurux.DLMS;
using System.ComponentModel;
using System.Xml.Serialization;
using GXDLMS.Common;
using System.Drawing.Design;

namespace GXDLMSDirector
{
    [GXDLMSViewAttribute(typeof(Views.GXDLMSGprsSetupView))]
    public class GXDLMSGprsSetup : GXDLMSBase
    {
        public override string ToString()
        {
            return base.ToString();
        }
        /// <summary> 
        /// Constructor.
        /// </summary> 
        public GXDLMSGprsSetup()
            : base(ObjectType.GprsSetup)
        {
        }

        [XmlIgnore()]
        [GXDLMSAttributeIndex(2, DataType.String)]
        public string APN
        {
            get;
            set;
        }

        [XmlIgnore()]
        [GXDLMSAttributeIndex(3, DataType.OctetString)]
        public long PINCode
        {
            get;
            set;
        }

        [XmlIgnore()]
        [GXDLMSAttributeIndex(4, DataType.OctetString)]
        public object QualityOfService
        {
            get;
            set;
        }
    }
}
