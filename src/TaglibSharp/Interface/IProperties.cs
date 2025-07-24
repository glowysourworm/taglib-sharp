using System;
using System.Collections.Generic;
using System.Text;

namespace TagLib.Interface
{
	/// <summary>
	/// Public interface for the abstract class Properties - which consolidates the IAudioCodec, IVideoCodec, and IPhotoCodec
	/// into one for use with other inheritance patterns.
	/// </summary>
	public interface IProperties : IAudioCodec, IVideoCodec, IPhotoCodec
	{
	}
}
