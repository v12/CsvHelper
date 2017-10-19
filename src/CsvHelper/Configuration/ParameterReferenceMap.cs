﻿// Copyright 2009-2017 Josh Close and Contributors
// This file is a part of CsvHelper and is dual licensed under MS-PL and Apache 2.0.
// See LICENSE.txt for details or visit http://www.opensource.org/licenses/ms-pl.html for MS-PL and http://opensource.org/licenses/Apache-2.0 for Apache 2.0.
// https://github.com/JoshClose/CsvHelper
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CsvHelper.Configuration
{
	/// <summary>
	/// Mapping info for a reference parameter mapping to a class.
	/// </summary>
	public class ParameterReferenceMap
    {
		private readonly ParameterReferenceMapData data;

		/// <summary>
		/// Gets the parameter reference map data.
		/// </summary>
		public ParameterReferenceMapData Data => data;

		/// <summary>
		/// Initializes a new instance of the <see cref="ParameterReferenceMap"/> class.
		/// </summary>
		/// <param name="parameter">The parameter.</param>
		/// <param name="mapping">The <see cref="ClassMap"/> to use for the reference map.</param>
		public ParameterReferenceMap( ParameterInfo parameter, ClassMap mapping )
		{
			if( mapping == null )
			{
				throw new ArgumentNullException( nameof( mapping ) );
			}

			data = new ParameterReferenceMapData( parameter, mapping );
		}

		/// <summary>
		/// Get the largest index for the
		/// members and references.
		/// </summary>
		/// <returns>The max index.</returns>
		internal int GetMaxIndex()
		{
			return data.Mapping.GetMaxIndex();
		}
	}
}