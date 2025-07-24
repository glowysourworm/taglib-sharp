using static TagLib.File;

namespace TagLib.Interface
{
	/// <summary>
	/// Interface for the public abstract class TagLib.File. This is used for inheritance patterns.
	/// </summary>
	public interface ITagFile
	{
		/// <summary>
		///    Gets a abstract representation of all tags stored in the
		///    current instance.
		/// </summary>
		/// <value>
		///    A <see cref="TagLib.Tag" /> object representing all tags stored in the current instance.
		/// </value>
		/// <remarks>
		///    <para>This property provides generic and general access to the most common tagging features of a file. To access
		///    or add a specific type of tag in the file, use GetTag(TagLib.TagTypes,bool)</para>
		/// </remarks>
		Tag Tag { get; }

		/// <summary>
		///    Gets the media properties of the file represented by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="TagLib.Properties" /> object containing the media properties of the file represented by the current instance.
		/// </value>
		Properties Properties { get; }

		/// <summary>
		///    Gets the tag types contained in the physical file represented by the current instance.
		/// </summary>
		/// <value>
		///    A bitwise combined <see cref="TagLib.TagTypes" /> value containing the tag types stored in the physical file as it was read or last saved.
		/// </value>
		TagTypes TagTypesOnDisk { get; }

		/// <summary>
		///    Gets the tag types contained in the current instance.
		/// </summary>
		/// <value>
		///    A bitwise combined <see cref="TagLib.TagTypes" /> value containing the tag types stored in the current instance.
		/// </value>
		TagTypes TagTypes { get; }

		/// <summary>
		///    Gets the name of the file as stored in its file abstraction.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the name of the file as stored in the <see cref="IFileAbstraction" /> object used to create it or the path if created with a local path.
		/// </value>
		string Name { get; }

		/// <summary>
		///    Gets the mime-type of the file as determined by <see cref="Create(IFileAbstraction,string,ReadStyle)" /> if
		///    that method was used to create the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the mime-type used to create the file or <see langword="null" /> if <see
		///    cref="Create(IFileAbstraction,string,ReadStyle)" /> was not used to create the current instance.
		/// </value>
		string MimeType { get; }

		/// <summary>Gets the seek position in the internal stream used by the current instance.</summary>
		/// <value>
		///    A <see cref="long" /> value representing the seek position, or 0 if the file is not open for reading.
		/// </value>
		long Tell { get; }

		/// <summary>
		///    Gets the length of the file represented by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="long" /> value representing the size of the file, or 0 if the file is not open for reading.
		/// </value>
		long Length { get; }

		/// <summary>
		///    Gets the position at which the invariant portion of the current instance begins.
		/// </summary>
		/// <value>
		///    A <see cref="long" /> value representing the seek position at which the file's invariant (media) data section begins. If the value could not be determined,
		///    <c>-1</c> is returned.
		/// </value>
		long InvariantStartPosition { get; }

		/// <summary>
		///    Gets the position at which the invariant portion of the current instance ends.
		/// </summary>
		/// <value>
		///    A <see cref="long" /> value representing the seek position at which the file's invariant (media) data section ends. If the value could not be determined,
		///    <c>-1</c> is returned.
		/// </value>
		long InvariantEndPosition { get; }

		/// <summary>
		///    Gets and sets the file access mode in use by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="AccessMode" /> value describing the features of stream currently in use by the current instance.
		/// </value>
		/// <remarks>
		///    Changing the value will cause the stream currently in use to be closed, except when a change is made from <see cref="AccessMode.Write" /> to <see cref="AccessMode.Read" /> which has no effect.
		/// </remarks>
		AccessMode Mode { get; set; }

		/// <summary>
		/// Gets the <see cref="IFileAbstraction"/> representing the file.
		/// </summary>
		public IFileAbstraction FileAbstraction { get; }

		/// <summary>
		///    Indicates if tags can be written back to the current file or not
		/// </summary>
		/// <value>
		///    A <see cref="bool" /> which is true if tags can be written to the current file, otherwise false.
		/// </value>
		bool Writeable { get; }

		/// <summary>
		///   Indicates whether or not this file may be corrupt.
		/// </summary>
		/// <value>
		/// <c>true</c> if possibly corrupt; otherwise, <c>false</c>.
		/// </value>
		/// <remarks>
		///    Files with unknown corruptions should not be written.
		/// </remarks>
		bool PossiblyCorrupt { get; }

		/// <summary>
		///   The reasons for which this file is marked as corrupt.
		/// </summary>
		IEnumerable<string> CorruptionReasons { get; }
	}
}
