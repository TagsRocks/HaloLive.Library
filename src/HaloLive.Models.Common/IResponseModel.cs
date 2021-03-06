﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HaloLive.Models
{
	//The concept here is that response models should be related to a request.
	//The request should have an enumerable state of results that the response can be in.
	/// <summary>
	/// Contract for models that are responses to a request.
	/// </summary>
	public interface IResponseModel<out TResultType>
		where TResultType : struct, IComparable //try to constrain to enum
	{
		/// <summary>
		/// Indicates the result of the response.
		/// </summary>
		TResultType ResultCode { get; }
	}
}
