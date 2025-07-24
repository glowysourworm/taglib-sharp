namespace TagLib.Interface
{
	/// <summary>
	/// Interface for TagLib.Tag abstract class. This is a nicety for those inheriting from the library to
	/// utilize copies of the tag data.
	/// </summary>
	public interface ITag
	{
		/// <summary>
		///    Gets the tag types contained in the current instance.
		/// </summary>
		/// <value>
		///    Always <see cref="TagTypes.Id3v2" />.
		/// </value>
		TagTypes TagTypes { get; }

		/// <summary>
		///    Gets and sets the title for the media described by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the title for the media described by the current instance or <see langword="null" /> if no value is present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TIT2" Text Information Frame.
		/// </remarks>
		string Title { get; }

		/// <summary>
		///    Gets and sets the sort names of the Title of the
		///    media represented by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the sort names for
		///    the Title of the media described by the current instance,
		///    or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TSOT" Text Information Frame.
		/// </remarks>
		string TitleSort { get; set; }


		/// <summary>
		///    Gets and sets a short description, one-liner. 
		///    It represents the tagline of the Video/music.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the subtitle
		///    the media represented by the current instance 
		///    or an empty array if no value is present.
		/// </value>
		/// <remarks>
		///    <para>This field gives a nice/short precision to 
		///    the title, which is typically below the title on the
		///    front cover of a media.
		///    For example, for "Back to the future", this would be 
		///    "It's About Time". 
		///    </para>
		/// </remarks>
		/// <remarks>
		///    This property is implemented using the "TIT3" Text
		///    Information Frame.
		/// </remarks>
		string Subtitle { get; set; }

		/// <summary>
		///    Gets and sets a short description of the media.
		///    For a music, this could be the comment that the artist
		///    made of its artwork. For a video, this should be a 
		///    short summary of the story/plot, but a spoiler. This
		///    should give the impression of what to expect in the
		///    media.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the subtitle
		///    the media represented by the current instance 
		///    or an empty array if no value is present.
		/// </value>
		/// <remarks>
		///    <para>This is especially relevant for a movie.
		///    For example, for "Back to the Future 2", this could be
		///    "After visiting 2015, Marty McFly must repeat his visit 
		///    to 1955 to prevent disastrous changes to 1985...without
		///    interfering with his first trip".
		///    </para>
		/// </remarks>
		string Description { get; set; }


		/// <summary>
		///    Gets and sets the performers or artists who performed in
		///    the media described by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="T:string[]" /> containing the performers or
		///    artists who performed in the media described by the
		///    current instance or an empty array if no value is
		///    present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TPE1" Text
		///    Information Frame.
		/// </remarks>
		string[] Performers { get; set; }

		/// <summary>
		///    Gets and sets the sort names of the performers or artists
		///    who performed in the media described by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="T:string[]" /> containing the sort names for
		///    the performers or artists who performed in the media
		///    described by the current instance, or an empty array if
		///    no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TSOP" Text
		///    Information Frame. http://www.id3.org/id3v2.4.0-frames
		/// </remarks>
		string[] PerformersSort { get; set; }

		/// <summary>
		///    Gets and sets the Charaters for a video media, or
		///    instruments played for music media. 
		///    This should match the <see cref="Performers"/> array (for
		///    each person correspond one/more role). Several roles for
		///    the same artist/actor can be made up with semicolons. 
		///    For example, "Marty McFly; Marty McFly Jr.; Marlene McFly".
		/// </summary>
		/// <remarks>
		///    <para> This is typically usefull for movies, although the
		///    instrument played by each artist in a music may be of
		///    relevance.
		///    </para>
		///    <para>It is highly important to match each role to the 
		///    performers. This means that a role may be <see 
		///    langword="null"/> to keep the match between a
		///    Performers[i] and PerformersRole[i].
		///    </para>
		/// </remarks>
		/// <remarks>
		///    This property is implemented using the "TMCL" Text
		///    Information Frame: The 'Musician credits list' is 
		///    intended as a mapping between instruments and the 
		///    musician that played it.Every odd field is an 
		///    instrument and every even is an artist or a comma 
		///    delimited list of artists.
		/// </remarks>
		string[] PerformersRole { get; set; }


		/// <summary>
		///    Gets and sets the sort names of the band or artist who is 
		///    credited in the creation of the entire album or collection
		///    containing the media described by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="T:string[]" /> containing the sort names for
		///    the performers or artists who performed in the media
		///    described by the current instance, or an empty array if
		///    no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TSO2" Text
		///    Information Frame. http://www.id3.org/iTunes
		/// </remarks>
		string[] AlbumArtistsSort { get; set; }

		/// <summary>
		///    Gets and sets the band or artist who is credited in the
		///    creation of the entire album or collection containing the
		///    media described by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="T:string[]" /> containing the band or artist
		///    who is credited in the creation of the entire album or
		///    collection containing the media described by the current
		///    instance or an empty array if no value is present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TPE2" Text
		///    Information Frame.
		/// </remarks>
		string[] AlbumArtists { get; set; }

		/// <summary>
		///    Gets and sets the composers of the media represented by
		///    the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="T:string[]" /> containing the composers of the
		///    media represented by the current instance or an empty
		///    array if no value is present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TCOM" Text
		///    Information Frame.
		/// </remarks>
		string[] Composers { get; set; }

		/// <summary>
		///    Gets and sets the sort names of the composers of the
		///    media represented by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="T:string[]" /> containing the sort names for
		///    the performers or artists who performed in the media
		///    described by the current instance, or an empty array if
		///    no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TSOC" Text
		///    Information Frame. http://www.id3.org/id3v2.4.0-frames
		/// </remarks>
		string[] ComposersSort { get; set; }

		/// <summary>
		///    Gets and sets the album of the media represented by the
		///    current instance.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the album of
		///    the media represented by the current instance or <see
		///    langword="null" /> if no value is present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TALB" Text
		///    Information Frame.
		/// </remarks>
		string Album { get; set; }

		/// <summary>
		///    Gets and sets the sort names of the Album title of the
		///    media represented by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the sort names for
		///    the Title in the media described by the current instance,
		///    or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TSOA" Text
		///    Information Frame. http://www.id3.org/id3v2.4.0-frames
		/// </remarks>
		string AlbumSort { get; set; }

		/// <summary>
		///    Gets and sets a user comment on the media represented by
		///    the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing user comments
		///    on the media represented by the current instance or <see
		///    langword="null" /> if no value is present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "COMM" Comments
		///    Frame with an empty description and the language
		///    specified by (see public static) Language.
		/// </remarks>
		string Comment { get; set; }

		/// <summary>
		///    Gets and sets the genres of the media represented by the
		///    current instance.
		/// </summary>
		/// <value>
		///    A <see cref="T:string[]" /> containing the genres of the
		///    media represented by the current instance or an empty
		///    array if no value is present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TCON" Text
		///    Information Frame.
		/// </remarks>
		string[] Genres { get; set; }

		/// <summary>
		///    Gets and sets the year that the media represented by the
		///    current instance was recorded.
		/// </summary>
		/// <value>
		///    A <see cref="uint" /> containing the year that the media
		///    represented by the current instance was created or zero
		///    if no value is present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TDRC" Text
		///    Information Frame. If a value greater than 9999 is set,
		///    this property will be cleared.
		/// </remarks>
		uint Year { get; set; }

		/// <summary>
		///    Gets and sets the position of the media represented by
		///    the current instance in its containing album.
		/// </summary>
		/// <value>
		///    A <see cref="uint" /> containing the position of the
		///    media represented by the current instance in its
		///    containing album or zero if not specified.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TRCK" Text
		///    Information Frame.
		/// </remarks>
		uint Track { get; set; }

		/// <summary>
		///    Gets and sets the number of tracks in the album
		///    containing the media represented by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="uint" /> containing the number of tracks in
		///    the album containing the media represented by the current
		///    instance or zero if not specified.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TRCK" Text
		///    Information Frame.
		/// </remarks>
		uint TrackCount { get; set; }

		/// <summary>
		///    Gets and sets the number of the disc containing the media
		///    represented by the current instance in the boxed set.
		/// </summary>
		/// <value>
		///    A <see cref="uint" /> containing the number of the disc
		///    containing the media represented by the current instance
		///    in the boxed set.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TPOS" Text
		///    Information Frame.
		/// </remarks>
		uint Disc { get; set; }

		/// <summary>
		///    Gets and sets the number of discs in the boxed set
		///    containing the media represented by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="uint" /> containing the number of discs in
		///    the boxed set containing the media represented by the
		///    current instance or zero if not specified.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TPOS" Text
		///    Information Frame.
		/// </remarks>
		uint DiscCount { get; set; }

		/// <summary>
		///    Gets and sets the lyrics or script of the media
		///    represented by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the lyrics or
		///    script of the media represented by the current instance
		///    or <see langword="null" /> if no value is present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "USLT"
		///    Unsynchronized Lyrics Frame with an empty description and
		///    the language specified by (see public static) Language.
		/// </remarks>
		string Lyrics { get; set; }

		/// <summary>
		///    Gets and sets the grouping on the album which the media
		///    in the current instance belongs to.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the grouping on
		///    the album which the media in the current instance belongs
		///    to or <see langword="null" /> if no value is present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TIT1" Text
		///    Information Frame.
		/// </remarks>
		string Grouping { get; set; }

		/// <summary>
		///    Gets and sets the number of beats per minute in the audio
		///    of the media represented by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="uint" /> containing the number of beats per
		///    minute in the audio of the media represented by the
		///    current instance, or zero if not specified.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TBPM" Text
		///    Information Frame.
		/// </remarks>
		uint BeatsPerMinute { get; set; }

		/// <summary>
		///    Gets and sets the conductor or director of the media
		///    represented by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the conductor
		///    or director of the media represented by the current
		///    instance or <see langword="null" /> if no value present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TPE3" Text
		///    Information Frame.
		/// </remarks>
		string Conductor { get; set; }

		/// <summary>
		///    Gets and sets the copyright information for the media
		///    represented by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the copyright
		///    information for the media represented by the current
		///    instance or <see langword="null" /> if no value present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TCOP" Text
		///    Information Frame.
		/// </remarks>
		string Copyright { get; set; }

		/// <summary>
		///    Gets and sets the date at which the tag has been written.
		/// </summary>
		/// <value>
		///    A nullable <see cref="DateTime" /> object containing the 
		///    date at which the tag has been written, or <see 
		///    langword="null" /> if no value present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TDTG" Timestamp
		///    Information Frame.
		/// </remarks>
		DateTime? DateTagged { get; set; }

		/// <summary>
		///    Gets and sets the MusicBrainz ArtistID
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the MusicBrainz
		///    ArtistID for the media described by the current 
		///    instance, or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:MusicBrainz Artist Id" frame.
		///    http://musicbrainz.org/doc/PicardTagMapping
		/// </remarks>
		string MusicBrainzArtistId { get; set; }

		/// <summary>
		///    Gets and sets the MusicBrainz ReleaseGroupID
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the MusicBrainz
		///    ReleaseGroupID for the media described by the current 
		///    instance, or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:MusicBrainz Release Group Id" frame.
		///    http://musicbrainz.org/doc/PicardTagMapping
		/// </remarks>
		string MusicBrainzReleaseGroupId { get; set; }

		/// <summary>
		///    Gets and sets the MusicBrainz ReleaseID
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the MusicBrainz
		///    ReleaseID for the media described by the current 
		///    instance, or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:MusicBrainz Album Id" frame.
		///    http://musicbrainz.org/doc/PicardTagMapping
		/// </remarks>
		string MusicBrainzReleaseId { get; set; }

		/// <summary>
		///    Gets and sets the MusicBrainz ReleaseArtistID
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the MusicBrainz
		///    ReleaseArtistID for the media described by the current 
		///    instance, or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:MusicBrainz Album Artist Id" frame.
		///    http://musicbrainz.org/doc/PicardTagMapping
		/// </remarks>
		string MusicBrainzReleaseArtistId { get; set; }

		/// <summary>
		///    Gets and sets the MusicBrainz TrackID
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the MusicBrainz
		///    TrackID for the media described by the current 
		///    instance, or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:MusicBrainz Release Track Id" frame.
		///    http://musicbrainz.org/doc/PicardTagMapping
		/// </remarks>
		string MusicBrainzTrackId { get; set; }

		/// <summary>
		///    Gets and sets the MusicBrainz RecordingID
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the MusicBrainz
		///    RecordingID for the media described by the current 
		///    instance, or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "UFID:http://musicbrainz.org" frame.
		///    http://musicbrainz.org/doc/PicardTagMapping
		/// </remarks>
		string MusicBrainzRecordingId { get; set; }

		/// <summary>
		///    Gets and sets the MusicBrainz WorkID
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the MusicBrainz
		///    WorkID for the media described by the current 
		///    instance, or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:MusicBrainz Work Id" frame.
		///    http://musicbrainz.org/doc/PicardTagMapping
		/// </remarks>
		string MusicBrainzWorkId { get; set; }

		/// <summary>
		///    Gets and sets the MusicBrainz DiscID
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the MusicBrainz
		///    DiscID for the media described by the current 
		///    instance, or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:MusicBrainz Disc Id" frame.
		///    http://musicbrainz.org/doc/PicardTagMapping
		/// </remarks>
		string MusicBrainzDiscId { get; set; }

		/// <summary>
		///    Gets and sets the MusicIP PUID
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the MusicIP PUID
		///    for the media described by the current 
		///    instance, or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:MusicIP PUID" frame.
		///    http://musicbrainz.org/doc/PicardTagMapping
		/// </remarks>
		string MusicIpId { get; set; }

		/// <summary>
		///    Gets and sets the Amazon ID (ASIN)
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the Amazon Id
		///    for the media described by the current 
		///    instance, or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:ASIN" frame.
		///    http://musicbrainz.org/doc/PicardTagMapping
		/// </remarks>
		string AmazonId { get; set; }

		/// <summary>
		///    Gets and sets the MusicBrainz ReleaseStatus
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the MusicBrainz
		///    ReleaseStatus for the media described by the current 
		///    instance, or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:MusicBrainz Album Status" frame.
		///    http://musicbrainz.org/doc/PicardTagMapping
		/// </remarks>
		string MusicBrainzReleaseStatus { get; set; }

		/// <summary>
		///    Gets and sets the MusicBrainz ReleaseType
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the MusicBrainz
		///    ReleaseType for the media described by the current 
		///    instance, or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:MusicBrainz Album Type" frame.
		///    http://musicbrainz.org/doc/PicardTagMapping
		/// </remarks>
		string MusicBrainzReleaseType { get; set; }

		/// <summary>
		///    Gets and sets the MusicBrainz ReleaseCountry
		/// </summary>
		/// <value>
		///    A <see cref="string" /> containing the MusicBrainz
		///    ReleaseCountry for the media described by the current 
		///    instance, or null if no value is present. 
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:MusicBrainz Album Release Country" frame.
		///    http://musicbrainz.org/doc/PicardTagMapping
		/// </remarks>
		string MusicBrainzReleaseCountry { get; set; }

		/// <summary>
		///    Gets and sets the ReplayGain track gain in dB.
		/// </summary>
		/// <value>
		///    A <see cref="bool" /> value in dB for the track gain as
		///    per the ReplayGain specification.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:REPLAYGAIN_TRACK_GAIN" frame.
		///    http://wiki.hydrogenaudio.org/index.php?title=ReplayGain_specification#ID3v2
		/// </remarks>
		double ReplayGainTrackGain { get; set; }

		/// <summary>
		///    Gets and sets the ReplayGain track peak sample.
		/// </summary>
		/// <value>
		///    A <see cref="bool" /> value for the track peak as per the
		///    ReplayGain specification.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:REPLAYGAIN_TRACK_PEAK" frame.
		///    http://wiki.hydrogenaudio.org/index.php?title=ReplayGain_specification#ID3v2
		/// </remarks>
		double ReplayGainTrackPeak { get; set; }

		/// <summary>
		///    Gets and sets the ReplayGain album gain in dB.
		/// </summary>
		/// <value>
		///    A <see cref="bool" /> value in dB for the album gain as
		///    per the ReplayGain specification.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:REPLAYGAIN_ALBUM_GAIN" frame.
		///    http://wiki.hydrogenaudio.org/index.php?title=ReplayGain_specification#ID3v2
		/// </remarks>
		double ReplayGainAlbumGain { get; set; }

		/// <summary>
		///    Gets and sets the ReplayGain album peak sample.
		/// </summary>
		/// <value>
		///    A <see cref="bool" /> value for the album peak as per the
		///    ReplayGain specification.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TXXX:REPLAYGAIN_ALBUM_PEAK" frame.
		///    http://wiki.hydrogenaudio.org/index.php?title=ReplayGain_specification#ID3v2
		/// </remarks>
		double ReplayGainAlbumPeak { get; set; }

		/// <summary>
		///    Gets and sets the initial key of the song.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the initial key of the song.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TKEY" field.
		/// </remarks>
		string InitialKey { get; set; }

		/// <summary>
		///    Gets and sets the remixer of the song.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the remixer of the song.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TPE4" field.
		/// </remarks>
		string RemixedBy { get; set; }

		/// <summary>
		///    Gets and sets the publisher of the song.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the publisher of the song.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TPUB" field.
		/// </remarks>
		string Publisher { get; set; }

		/// <summary>
		///    Gets and sets the ISRC (International Standard Recording Code) of the song.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the ISRC of the song.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TSRC" field.
		/// </remarks>
		string ISRC { get; set; }

		/// <summary>
		///    Gets and sets the length of the media represented
		///    by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="string" /> object containing the length of
		///    the media represented by the current instance or <see
		///    langword="null" /> if no value is present.
		/// </value>
		/// <remarks>
		///    <para>This field represents the label or length of the album the
		///    media belongs to. </para>
		///    <para>For example, "00:15:00".</para>
		/// </remarks>
		string Length { get; set; }

		/// <summary>
		///    Gets and sets a collection of pictures associated with
		///    the media represented by the current instance.
		/// </summary>
		/// <value>
		///    A <see cref="T:IPicture[]" /> containing a collection of
		///    pictures associated with the media represented by the
		///    current instance or an empty array if none are present.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "APIC" Attached
		///    Picture Frame.
		/// </remarks>
		IPicture[] Pictures { get; set; }

		/// <summary>
		///    Gets whether or not the current instance is empty.
		/// </summary>
		/// <value>
		///    <see langword="true" /> if the current instance does not
		///    any values. Otherwise <see langword="false" />.
		/// </value>
		bool IsEmpty { get; }

		/// <summary>
		///    Clears the values stored in the current instance.
		/// </summary>
		void Clear ();

		/// <summary>
		///    Gets and sets whether or not the album described by the
		///    current instance is a compilation.
		/// </summary>
		/// <value>
		///    A <see cref="bool" /> value indicating whether or not the
		///    album described by the current instance is a compilation.
		/// </value>
		/// <remarks>
		///    This property is implemented using the "TCMP" Text
		///    Information Frame to provide support for a feature of the
		///    Apple iPod and iTunes products.
		/// </remarks>
		public bool IsCompilation { get; set; }
	}
}
