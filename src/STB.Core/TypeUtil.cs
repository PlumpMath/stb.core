/*---------------------------------------------------------------------------------------------
 * Copyright (c) STB Chain. All rights reserved.
 * Licensed under the Source EULA. See License in the project root for license information.
 * Source code : https://github.com/stbchain
 * Website : http://www.soft2b.com/
 *---------------------------------------------------------------------------------------------
 ---------------------------------------------------------------------------------------------*/

using System;
using System.ComponentModel;
using System.Reflection;

namespace STB.Core
{
    /// <summary>
    ///     Type Util
    /// </summary>
    public class TypeUtil
    {
        /// <summary>
        ///     Get the NestType in a Nullable
        /// </summary>
        /// <param name="conversionType"></param>
        /// <returns></returns>
        public static Type GetUnNullableType(Type conversionType)
        {
            if (conversionType.GetTypeInfo().IsGenericType &&
                conversionType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                //����Ƿ��ͷ������ҷ�������ΪNullable<>����Ϊ�ɿ�����
                //��ʹ��NullableConverterת��������ת��
                var nullableConverter = new NullableConverter(conversionType);
                conversionType = nullableConverter.UnderlyingType;
            }

            return conversionType;
        }
    }
}