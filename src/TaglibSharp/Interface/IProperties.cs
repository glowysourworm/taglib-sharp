namespace TagLib.Interface
{
	/// <summary>
	/// Public interface for the abstract class Properties - which consolidates the IAudioCodec, IVideoCodec, and IPhotoCodec
	/// into one for use with other inheritance patterns.
	/// </summary>
	public interface IProperties : ILosslessAudioCodec, IAudioCodec, IVideoCodec, IPhotoCodec
	{
		/// <summary>
		/// Codecs associated with the media file
		/// </summary>
		IEnumerable<ICodec> Codecs { get; }
	}
}
