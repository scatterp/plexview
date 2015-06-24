#region License
/* Copyright (c) 2008, Katharine Berry
 * All rights reserved.
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of Katharine Berry nor the names of any contributors
 *       may be used to endorse or promote products derived from this software
 *       without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY KATHARINE BERRY ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL KATHARINE BERRY BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 ******************************************************************************/
#endregion
using System;
using System.Collections.Generic;

using OpenMetaverse;

namespace PlexView
{

	public class User : GridClient
	{

		public DateTime lastRequest;
		public readonly Guid sessionID;
		public readonly Creds creds;

		//@todo Instances of the client class should only be created by the ClientMgr
		public User(Creds creds)
		{
			Settings.ALWAYS_DECODE_OBJECTS = false;
			Settings.ALWAYS_REQUEST_OBJECTS = false;
			Settings.MULTIPLE_SIMS = false;
			Settings.ENABLE_SIMSTATS = true;
			Settings.LOGOUT_TIMEOUT = 20000;
			Settings.LOG_RESENDS = false;
			Settings.USE_ASSET_CACHE = false;
			Throttle.Cloud = 0;
			Throttle.Task = 0;
			Throttle.Wind = 0;
			Throttle.Asset = 50000;
			Throttle.Resend = 500000;
			Throttle.Texture = 500000;

			lastRequest = DateTime.Now;
			sessionID = Guid.NewGuid();
			this.creds = creds;
		}		
	}
}
