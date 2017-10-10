
Namespace PlexIsBusyPlugin
    Public Class Plex

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True),
 System.Xml.Serialization.XmlRootAttribute([Namespace]:="", IsNullable:=False)>
        Partial Public Class MediaContainer

            Private videoField() As MediaContainerVideo

            Private trackField() As MediaContainerTrack

            Private photoField() As MediaContainerPhoto

            Private sizeField As Integer

            '''<remarks/>
            <System.Xml.Serialization.XmlElementAttribute("Video")>
            Public Property Video() As MediaContainerVideo()
                Get
                    Return Me.videoField
                End Get
                Set
                    Me.videoField = Value
                End Set
            End Property

            '''<remarks/>
            Public Property Track() As MediaContainerTrack()
                Get
                    Return Me.trackField
                End Get
                Set
                    Me.trackField = Value
                End Set
            End Property

            '''<remarks/>
            Public Property Photo() As MediaContainerPhoto()
                Get
                    Return Me.photoField
                End Get
                Set
                    Me.photoField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property size() As Integer
                Get
                    Return Me.sizeField
                End Get
                Set
                    Me.sizeField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideo

            Private mediaField As MediaContainerVideoMedia

            Private genreField() As MediaContainerVideoGenre

            Private writerField As MediaContainerVideoWriter

            Private directorField As MediaContainerVideoDirector

            Private producerField() As MediaContainerVideoProducer

            Private countryField As MediaContainerVideoCountry

            Private roleField() As MediaContainerVideoRole

            Private collectionField As MediaContainerVideoCollection

            Private userField As MediaContainerVideoUser

            Private playerField As MediaContainerVideoPlayer

            Private transcodeSessionField As MediaContainerVideoTranscodeSession

            Private addedAtField As Integer

            Private artField As String

            Private durationField As Integer

            Private grandparentKeyField As String

            Private grandparentRatingKeyField As Integer

            Private grandparentRatingKeyFieldSpecified As Boolean

            Private grandparentThumbField As String

            Private grandparentTitleField As String

            Private guidField As String

            Private indexField As Integer

            Private indexFieldSpecified As Boolean

            Private keyField As String

            Private lastViewedAtField As Integer

            Private lastViewedAtFieldSpecified As Boolean

            Private librarySectionIDField As Integer

            Private originallyAvailableAtField As Date

            Private parentIndexField As Integer

            Private parentIndexFieldSpecified As Boolean

            Private parentKeyField As String

            Private parentRatingKeyField As Integer

            Private parentRatingKeyFieldSpecified As Boolean

            Private ratingField As Decimal

            Private ratingKeyField As Integer

            Private sessionKeyField As Integer

            Private summaryField As String

            Private thumbField As String

            Private titleField As String

            Private typeField As String

            Private updatedAtField As Integer

            Private viewOffsetField As Integer

            Private yearField As Integer

            Private ontentRatingField As String

            Private studioField As String

            Private taglineField As String

            '''<remarks/>
            Public Property Media() As MediaContainerVideoMedia
                Get
                    Return Me.mediaField
                End Get
                Set
                    Me.mediaField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlElementAttribute("Genre")>
            Public Property Genre() As MediaContainerVideoGenre()
                Get
                    Return Me.genreField
                End Get
                Set
                    Me.genreField = Value
                End Set
            End Property

            '''<remarks/>
            Public Property Writer() As MediaContainerVideoWriter
                Get
                    Return Me.writerField
                End Get
                Set
                    Me.writerField = Value
                End Set
            End Property

            '''<remarks/>
            Public Property Director() As MediaContainerVideoDirector
                Get
                    Return Me.directorField
                End Get
                Set
                    Me.directorField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlElementAttribute("Producer")>
            Public Property Producer() As MediaContainerVideoProducer()
                Get
                    Return Me.producerField
                End Get
                Set
                    Me.producerField = Value
                End Set
            End Property

            '''<remarks/>
            Public Property Country() As MediaContainerVideoCountry
                Get
                    Return Me.countryField
                End Get
                Set
                    Me.countryField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlElementAttribute("Role")>
            Public Property Role() As MediaContainerVideoRole()
                Get
                    Return Me.roleField
                End Get
                Set
                    Me.roleField = Value
                End Set
            End Property

            '''<remarks/>
            Public Property Collection() As MediaContainerVideoCollection
                Get
                    Return Me.collectionField
                End Get
                Set
                    Me.collectionField = Value
                End Set
            End Property

            '''<remarks/>
            Public Property User() As MediaContainerVideoUser
                Get
                    Return Me.userField
                End Get
                Set
                    Me.userField = Value
                End Set
            End Property

            '''<remarks/>
            Public Property Player() As MediaContainerVideoPlayer
                Get
                    Return Me.playerField
                End Get
                Set
                    Me.playerField = Value
                End Set
            End Property

            '''<remarks/>
            Public Property TranscodeSession() As MediaContainerVideoTranscodeSession
                Get
                    Return Me.transcodeSessionField
                End Get
                Set
                    Me.transcodeSessionField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property addedAt() As Integer
                Get
                    Return Me.addedAtField
                End Get
                Set
                    Me.addedAtField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property art() As String
                Get
                    Return Me.artField
                End Get
                Set
                    Me.artField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property duration() As Integer
                Get
                    Return Me.durationField
                End Get
                Set
                    Me.durationField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property grandparentKey() As String
                Get
                    Return Me.grandparentKeyField
                End Get
                Set
                    Me.grandparentKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property grandparentRatingKey() As Integer
                Get
                    Return Me.grandparentRatingKeyField
                End Get
                Set
                    Me.grandparentRatingKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property grandparentRatingKeySpecified() As Boolean
                Get
                    Return Me.grandparentRatingKeyFieldSpecified
                End Get
                Set
                    Me.grandparentRatingKeyFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property grandparentThumb() As String
                Get
                    Return Me.grandparentThumbField
                End Get
                Set
                    Me.grandparentThumbField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property grandparentTitle() As String
                Get
                    Return Me.grandparentTitleField
                End Get
                Set
                    Me.grandparentTitleField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property guid() As String
                Get
                    Return Me.guidField
                End Get
                Set
                    Me.guidField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property index() As Integer
                Get
                    Return Me.indexField
                End Get
                Set
                    Me.indexField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property indexSpecified() As Boolean
                Get
                    Return Me.indexFieldSpecified
                End Get
                Set
                    Me.indexFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property key() As String
                Get
                    Return Me.keyField
                End Get
                Set
                    Me.keyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property lastViewedAt() As Integer
                Get
                    Return Me.lastViewedAtField
                End Get
                Set
                    Me.lastViewedAtField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property lastViewedAtSpecified() As Boolean
                Get
                    Return Me.lastViewedAtFieldSpecified
                End Get
                Set
                    Me.lastViewedAtFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property librarySectionID() As Integer
                Get
                    Return Me.librarySectionIDField
                End Get
                Set
                    Me.librarySectionIDField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>
            Public Property originallyAvailableAt() As Date
                Get
                    Return Me.originallyAvailableAtField
                End Get
                Set
                    Me.originallyAvailableAtField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property parentIndex() As Integer
                Get
                    Return Me.parentIndexField
                End Get
                Set
                    Me.parentIndexField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property parentIndexSpecified() As Boolean
                Get
                    Return Me.parentIndexFieldSpecified
                End Get
                Set
                    Me.parentIndexFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property parentKey() As String
                Get
                    Return Me.parentKeyField
                End Get
                Set
                    Me.parentKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property parentRatingKey() As Integer
                Get
                    Return Me.parentRatingKeyField
                End Get
                Set
                    Me.parentRatingKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property parentRatingKeySpecified() As Boolean
                Get
                    Return Me.parentRatingKeyFieldSpecified
                End Get
                Set
                    Me.parentRatingKeyFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property rating() As Decimal
                Get
                    Return Me.ratingField
                End Get
                Set
                    Me.ratingField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property ratingKey() As Integer
                Get
                    Return Me.ratingKeyField
                End Get
                Set
                    Me.ratingKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property sessionKey() As Integer
                Get
                    Return Me.sessionKeyField
                End Get
                Set
                    Me.sessionKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property summary() As String
                Get
                    Return Me.summaryField
                End Get
                Set
                    Me.summaryField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property thumb() As String
                Get
                    Return Me.thumbField
                End Get
                Set
                    Me.thumbField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property title() As String
                Get
                    Return Me.titleField
                End Get
                Set
                    Me.titleField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property type() As String
                Get
                    Return Me.typeField
                End Get
                Set
                    Me.typeField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property updatedAt() As Integer
                Get
                    Return Me.updatedAtField
                End Get
                Set
                    Me.updatedAtField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property viewOffset() As Integer
                Get
                    Return Me.viewOffsetField
                End Get
                Set
                    Me.viewOffsetField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property year() As Integer
                Get
                    Return Me.yearField
                End Get
                Set
                    Me.yearField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property ontentRating() As String
                Get
                    Return Me.ontentRatingField
                End Get
                Set
                    Me.ontentRatingField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property studio() As String
                Get
                    Return Me.studioField
                End Get
                Set
                    Me.studioField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property tagline() As String
                Get
                    Return Me.taglineField
                End Get
                Set
                    Me.taglineField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideoMedia

            Private partField As MediaContainerVideoMediaPart

            Private aspectRatioField As Decimal

            Private audioChannelsField As Integer

            Private audioCodecField As String

            Private bitrateField As Integer

            Private containerField As String

            Private durationField As Integer

            Private heightField As Integer

            Private idField As Integer

            Private videoCodecField As String

            Private videoFrameRateField As String

            Private videoResolutionField As Integer

            Private widthField As Integer

            '''<remarks/>
            Public Property Part() As MediaContainerVideoMediaPart
                Get
                    Return Me.partField
                End Get
                Set
                    Me.partField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property aspectRatio() As Decimal
                Get
                    Return Me.aspectRatioField
                End Get
                Set
                    Me.aspectRatioField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property audioChannels() As Integer
                Get
                    Return Me.audioChannelsField
                End Get
                Set
                    Me.audioChannelsField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property audioCodec() As String
                Get
                    Return Me.audioCodecField
                End Get
                Set
                    Me.audioCodecField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property bitrate() As Integer
                Get
                    Return Me.bitrateField
                End Get
                Set
                    Me.bitrateField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property container() As String
                Get
                    Return Me.containerField
                End Get
                Set
                    Me.containerField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property duration() As Integer
                Get
                    Return Me.durationField
                End Get
                Set
                    Me.durationField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property height() As Integer
                Get
                    Return Me.heightField
                End Get
                Set
                    Me.heightField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property videoCodec() As String
                Get
                    Return Me.videoCodecField
                End Get
                Set
                    Me.videoCodecField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property videoFrameRate() As String
                Get
                    Return Me.videoFrameRateField
                End Get
                Set
                    Me.videoFrameRateField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property videoResolution() As Integer
                Get
                    Return Me.videoResolutionField
                End Get
                Set
                    Me.videoResolutionField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property width() As Integer
                Get
                    Return Me.widthField
                End Get
                Set
                    Me.widthField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideoMediaPart

            Private streamField() As MediaContainerVideoMediaPartStream

            Private containerField As String

            Private durationField As Integer

            Private fileField As String

            Private idField As Integer

            Private indexesField As String

            Private keyField As String

            Private sizeField As Integer

            '''<remarks/>
            <System.Xml.Serialization.XmlElementAttribute("Stream")>
            Public Property Stream() As MediaContainerVideoMediaPartStream()
                Get
                    Return Me.streamField
                End Get
                Set
                    Me.streamField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property container() As String
                Get
                    Return Me.containerField
                End Get
                Set
                    Me.containerField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property duration() As Integer
                Get
                    Return Me.durationField
                End Get
                Set
                    Me.durationField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property file() As String
                Get
                    Return Me.fileField
                End Get
                Set
                    Me.fileField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property indexes() As String
                Get
                    Return Me.indexesField
                End Get
                Set
                    Me.indexesField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property key() As String
                Get
                    Return Me.keyField
                End Get
                Set
                    Me.keyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property size() As Integer
                Get
                    Return Me.sizeField
                End Get
                Set
                    Me.sizeField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideoMediaPartStream

            Private bitDepthField As Integer

            Private bitrateField As Integer

            Private cabacField As Integer

            Private cabacFieldSpecified As Boolean

            Private chromaSubsamplingField As String

            Private codecField As String

            Private colorSpaceField As String

            Private durationField As Integer

            Private frameRateField As Decimal

            Private frameRateFieldSpecified As Boolean

            Private frameRateModeField As String

            Private hasScalingMatrixField As Integer

            Private hasScalingMatrixFieldSpecified As Boolean

            Private heightField As Integer

            Private heightFieldSpecified As Boolean

            Private idField As Integer

            Private indexField As Integer

            Private languageField As String

            Private languageCodeField As String

            Private levelField As Integer

            Private levelFieldSpecified As Boolean

            Private profileField As String

            Private refFramesField As Integer

            Private refFramesFieldSpecified As Boolean

            Private scanTypeField As String

            Private streamTypeField As Integer

            Private widthField As Integer

            Private widthFieldSpecified As Boolean

            Private bitrateModeField As String

            Private channelsField As Integer

            Private channelsFieldSpecified As Boolean

            Private dialogNormField As Integer

            Private dialogNormFieldSpecified As Boolean

            Private samplingRateField As Integer

            Private samplingRateFieldSpecified As Boolean

            Private selectedField As Integer

            Private selectedFieldSpecified As Boolean

            Private codecIDField As String

            Private titleField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property bitDepth() As Integer
                Get
                    Return Me.bitDepthField
                End Get
                Set
                    Me.bitDepthField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property bitrate() As Integer
                Get
                    Return Me.bitrateField
                End Get
                Set
                    Me.bitrateField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property cabac() As Integer
                Get
                    Return Me.cabacField
                End Get
                Set
                    Me.cabacField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property cabacSpecified() As Boolean
                Get
                    Return Me.cabacFieldSpecified
                End Get
                Set
                    Me.cabacFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property chromaSubsampling() As String
                Get
                    Return Me.chromaSubsamplingField
                End Get
                Set
                    Me.chromaSubsamplingField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property codec() As String
                Get
                    Return Me.codecField
                End Get
                Set
                    Me.codecField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property colorSpace() As String
                Get
                    Return Me.colorSpaceField
                End Get
                Set
                    Me.colorSpaceField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property duration() As Integer
                Get
                    Return Me.durationField
                End Get
                Set
                    Me.durationField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property frameRate() As Decimal
                Get
                    Return Me.frameRateField
                End Get
                Set
                    Me.frameRateField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property frameRateSpecified() As Boolean
                Get
                    Return Me.frameRateFieldSpecified
                End Get
                Set
                    Me.frameRateFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property frameRateMode() As String
                Get
                    Return Me.frameRateModeField
                End Get
                Set
                    Me.frameRateModeField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property hasScalingMatrix() As Integer
                Get
                    Return Me.hasScalingMatrixField
                End Get
                Set
                    Me.hasScalingMatrixField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property hasScalingMatrixSpecified() As Boolean
                Get
                    Return Me.hasScalingMatrixFieldSpecified
                End Get
                Set
                    Me.hasScalingMatrixFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property height() As Integer
                Get
                    Return Me.heightField
                End Get
                Set
                    Me.heightField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property heightSpecified() As Boolean
                Get
                    Return Me.heightFieldSpecified
                End Get
                Set
                    Me.heightFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property index() As Integer
                Get
                    Return Me.indexField
                End Get
                Set
                    Me.indexField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property language() As String
                Get
                    Return Me.languageField
                End Get
                Set
                    Me.languageField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property languageCode() As String
                Get
                    Return Me.languageCodeField
                End Get
                Set
                    Me.languageCodeField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property level() As Integer
                Get
                    Return Me.levelField
                End Get
                Set
                    Me.levelField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property levelSpecified() As Boolean
                Get
                    Return Me.levelFieldSpecified
                End Get
                Set
                    Me.levelFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property profile() As String
                Get
                    Return Me.profileField
                End Get
                Set
                    Me.profileField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property refFrames() As Integer
                Get
                    Return Me.refFramesField
                End Get
                Set
                    Me.refFramesField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property refFramesSpecified() As Boolean
                Get
                    Return Me.refFramesFieldSpecified
                End Get
                Set
                    Me.refFramesFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property scanType() As String
                Get
                    Return Me.scanTypeField
                End Get
                Set
                    Me.scanTypeField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property streamType() As Integer
                Get
                    Return Me.streamTypeField
                End Get
                Set
                    Me.streamTypeField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property width() As Integer
                Get
                    Return Me.widthField
                End Get
                Set
                    Me.widthField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property widthSpecified() As Boolean
                Get
                    Return Me.widthFieldSpecified
                End Get
                Set
                    Me.widthFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property bitrateMode() As String
                Get
                    Return Me.bitrateModeField
                End Get
                Set
                    Me.bitrateModeField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property channels() As Integer
                Get
                    Return Me.channelsField
                End Get
                Set
                    Me.channelsField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property channelsSpecified() As Boolean
                Get
                    Return Me.channelsFieldSpecified
                End Get
                Set
                    Me.channelsFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property dialogNorm() As Integer
                Get
                    Return Me.dialogNormField
                End Get
                Set
                    Me.dialogNormField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property dialogNormSpecified() As Boolean
                Get
                    Return Me.dialogNormFieldSpecified
                End Get
                Set
                    Me.dialogNormFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property samplingRate() As Integer
                Get
                    Return Me.samplingRateField
                End Get
                Set
                    Me.samplingRateField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property samplingRateSpecified() As Boolean
                Get
                    Return Me.samplingRateFieldSpecified
                End Get
                Set
                    Me.samplingRateFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property selected() As Integer
                Get
                    Return Me.selectedField
                End Get
                Set
                    Me.selectedField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlIgnoreAttribute()>
            Public Property selectedSpecified() As Boolean
                Get
                    Return Me.selectedFieldSpecified
                End Get
                Set
                    Me.selectedFieldSpecified = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property codecID() As String
                Get
                    Return Me.codecIDField
                End Get
                Set
                    Me.codecIDField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property title() As String
                Get
                    Return Me.titleField
                End Get
                Set
                    Me.titleField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideoGenre

            Private idField As Integer

            Private tagField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property tag() As String
                Get
                    Return Me.tagField
                End Get
                Set
                    Me.tagField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideoWriter

            Private idField As Integer

            Private tagField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property tag() As String
                Get
                    Return Me.tagField
                End Get
                Set
                    Me.tagField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideoDirector

            Private idField As Integer

            Private tagField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property tag() As String
                Get
                    Return Me.tagField
                End Get
                Set
                    Me.tagField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideoProducer

            Private idField As Integer

            Private tagField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property tag() As String
                Get
                    Return Me.tagField
                End Get
                Set
                    Me.tagField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideoCountry

            Private idField As Integer

            Private tagField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property tag() As String
                Get
                    Return Me.tagField
                End Get
                Set
                    Me.tagField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideoRole

            Private idField As Integer

            Private roleField As String

            Private tagField As String

            Private thumbField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property role() As String
                Get
                    Return Me.roleField
                End Get
                Set
                    Me.roleField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property tag() As String
                Get
                    Return Me.tagField
                End Get
                Set
                    Me.tagField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property thumb() As String
                Get
                    Return Me.thumbField
                End Get
                Set
                    Me.thumbField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideoCollection

            Private idField As Integer

            Private tagField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property tag() As String
                Get
                    Return Me.tagField
                End Get
                Set
                    Me.tagField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideoUser

            Private idField As Integer

            Private thumbField As String

            Private titleField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property thumb() As String
                Get
                    Return Me.thumbField
                End Get
                Set
                    Me.thumbField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property title() As String
                Get
                    Return Me.titleField
                End Get
                Set
                    Me.titleField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideoPlayer

            Private machineIdentifierField As String

            Private platformField As String

            Private stateField As String

            Private titleField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property machineIdentifier() As String
                Get
                    Return Me.machineIdentifierField
                End Get
                Set
                    Me.machineIdentifierField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property platform() As String
                Get
                    Return Me.platformField
                End Get
                Set
                    Me.platformField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property state() As String
                Get
                    Return Me.stateField
                End Get
                Set
                    Me.stateField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property title() As String
                Get
                    Return Me.titleField
                End Get
                Set
                    Me.titleField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerVideoTranscodeSession

            Private audioChannelsField As Integer

            Private audioCodecField As String

            Private audioDecisionField As String

            Private containerField As String

            Private durationField As Integer

            Private heightField As Integer

            Private keyField As String

            Private progressField As Decimal

            Private protocolField As String

            Private speedField As Decimal

            Private throttledField As Integer

            Private videoCodecField As String

            Private videoDecisionField As String

            Private widthField As Integer

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property audioChannels() As Integer
                Get
                    Return Me.audioChannelsField
                End Get
                Set
                    Me.audioChannelsField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property audioCodec() As String
                Get
                    Return Me.audioCodecField
                End Get
                Set
                    Me.audioCodecField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property audioDecision() As String
                Get
                    Return Me.audioDecisionField
                End Get
                Set
                    Me.audioDecisionField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property container() As String
                Get
                    Return Me.containerField
                End Get
                Set
                    Me.containerField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property duration() As Integer
                Get
                    Return Me.durationField
                End Get
                Set
                    Me.durationField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property height() As Integer
                Get
                    Return Me.heightField
                End Get
                Set
                    Me.heightField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property key() As String
                Get
                    Return Me.keyField
                End Get
                Set
                    Me.keyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property progress() As Decimal
                Get
                    Return Me.progressField
                End Get
                Set
                    Me.progressField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property protocol() As String
                Get
                    Return Me.protocolField
                End Get
                Set
                    Me.protocolField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property speed() As Decimal
                Get
                    Return Me.speedField
                End Get
                Set
                    Me.speedField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property throttled() As Integer
                Get
                    Return Me.throttledField
                End Get
                Set
                    Me.throttledField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property videoCodec() As String
                Get
                    Return Me.videoCodecField
                End Get
                Set
                    Me.videoCodecField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property videoDecision() As String
                Get
                    Return Me.videoDecisionField
                End Get
                Set
                    Me.videoDecisionField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property width() As Integer
                Get
                    Return Me.widthField
                End Get
                Set
                    Me.widthField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerTrack

            Private mediaField As MediaContainerTrackMedia

            Private userField As MediaContainerTrackUser

            Private playerField As MediaContainerTrackPlayer

            Private addedAtField As Integer

            Private artField As String

            Private durationField As Integer

            Private grandparentKeyField As String

            Private grandparentRatingKeyField As Integer

            Private grandparentThumbField As String

            Private grandparentTitleField As String

            Private guidField As String

            Private indexField As Integer

            Private keyField As String

            Private librarySectionIDField As Integer

            Private originalTitleField As String

            Private parentIndexField As Integer

            Private parentKeyField As String

            Private parentRatingKeyField As Integer

            Private parentThumbField As String

            Private parentTitleField As String

            Private ratingKeyField As Integer

            Private sessionKeyField As Integer

            Private summaryField As String

            Private thumbField As String

            Private titleField As String

            Private titleSortField As String

            Private typeField As String

            Private updatedAtField As Integer

            Private viewOffsetField As Integer

            '''<remarks/>
            Public Property Media() As MediaContainerTrackMedia
                Get
                    Return Me.mediaField
                End Get
                Set
                    Me.mediaField = Value
                End Set
            End Property

            '''<remarks/>
            Public Property User() As MediaContainerTrackUser
                Get
                    Return Me.userField
                End Get
                Set
                    Me.userField = Value
                End Set
            End Property

            '''<remarks/>
            Public Property Player() As MediaContainerTrackPlayer
                Get
                    Return Me.playerField
                End Get
                Set
                    Me.playerField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property addedAt() As Integer
                Get
                    Return Me.addedAtField
                End Get
                Set
                    Me.addedAtField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property art() As String
                Get
                    Return Me.artField
                End Get
                Set
                    Me.artField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property duration() As Integer
                Get
                    Return Me.durationField
                End Get
                Set
                    Me.durationField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property grandparentKey() As String
                Get
                    Return Me.grandparentKeyField
                End Get
                Set
                    Me.grandparentKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property grandparentRatingKey() As Integer
                Get
                    Return Me.grandparentRatingKeyField
                End Get
                Set
                    Me.grandparentRatingKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property grandparentThumb() As String
                Get
                    Return Me.grandparentThumbField
                End Get
                Set
                    Me.grandparentThumbField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property grandparentTitle() As String
                Get
                    Return Me.grandparentTitleField
                End Get
                Set
                    Me.grandparentTitleField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property guid() As String
                Get
                    Return Me.guidField
                End Get
                Set
                    Me.guidField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property index() As Integer
                Get
                    Return Me.indexField
                End Get
                Set
                    Me.indexField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property key() As String
                Get
                    Return Me.keyField
                End Get
                Set
                    Me.keyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property librarySectionID() As Integer
                Get
                    Return Me.librarySectionIDField
                End Get
                Set
                    Me.librarySectionIDField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property originalTitle() As String
                Get
                    Return Me.originalTitleField
                End Get
                Set
                    Me.originalTitleField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property parentIndex() As Integer
                Get
                    Return Me.parentIndexField
                End Get
                Set
                    Me.parentIndexField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property parentKey() As String
                Get
                    Return Me.parentKeyField
                End Get
                Set
                    Me.parentKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property parentRatingKey() As Integer
                Get
                    Return Me.parentRatingKeyField
                End Get
                Set
                    Me.parentRatingKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property parentThumb() As String
                Get
                    Return Me.parentThumbField
                End Get
                Set
                    Me.parentThumbField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property parentTitle() As String
                Get
                    Return Me.parentTitleField
                End Get
                Set
                    Me.parentTitleField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property ratingKey() As Integer
                Get
                    Return Me.ratingKeyField
                End Get
                Set
                    Me.ratingKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property sessionKey() As Integer
                Get
                    Return Me.sessionKeyField
                End Get
                Set
                    Me.sessionKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property summary() As String
                Get
                    Return Me.summaryField
                End Get
                Set
                    Me.summaryField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property thumb() As String
                Get
                    Return Me.thumbField
                End Get
                Set
                    Me.thumbField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property title() As String
                Get
                    Return Me.titleField
                End Get
                Set
                    Me.titleField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property titleSort() As String
                Get
                    Return Me.titleSortField
                End Get
                Set
                    Me.titleSortField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property type() As String
                Get
                    Return Me.typeField
                End Get
                Set
                    Me.typeField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property updatedAt() As Integer
                Get
                    Return Me.updatedAtField
                End Get
                Set
                    Me.updatedAtField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property viewOffset() As Integer
                Get
                    Return Me.viewOffsetField
                End Get
                Set
                    Me.viewOffsetField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerTrackMedia

            Private partField As MediaContainerTrackMediaPart

            Private audioChannelsField As Integer

            Private audioCodecField As String

            Private bitrateField As Integer

            Private containerField As String

            Private durationField As Integer

            Private idField As Integer

            '''<remarks/>
            Public Property Part() As MediaContainerTrackMediaPart
                Get
                    Return Me.partField
                End Get
                Set
                    Me.partField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property audioChannels() As Integer
                Get
                    Return Me.audioChannelsField
                End Get
                Set
                    Me.audioChannelsField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property audioCodec() As String
                Get
                    Return Me.audioCodecField
                End Get
                Set
                    Me.audioCodecField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property bitrate() As Integer
                Get
                    Return Me.bitrateField
                End Get
                Set
                    Me.bitrateField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property container() As String
                Get
                    Return Me.containerField
                End Get
                Set
                    Me.containerField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property duration() As Integer
                Get
                    Return Me.durationField
                End Get
                Set
                    Me.durationField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerTrackMediaPart

            Private streamField As MediaContainerTrackMediaPartStream

            Private containerField As String

            Private durationField As Integer

            Private fileField As String

            Private idField As Integer

            Private keyField As String

            Private sizeField As Integer

            '''<remarks/>
            Public Property Stream() As MediaContainerTrackMediaPartStream
                Get
                    Return Me.streamField
                End Get
                Set
                    Me.streamField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property container() As String
                Get
                    Return Me.containerField
                End Get
                Set
                    Me.containerField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property duration() As Integer
                Get
                    Return Me.durationField
                End Get
                Set
                    Me.durationField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property file() As String
                Get
                    Return Me.fileField
                End Get
                Set
                    Me.fileField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property key() As String
                Get
                    Return Me.keyField
                End Get
                Set
                    Me.keyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property size() As Integer
                Get
                    Return Me.sizeField
                End Get
                Set
                    Me.sizeField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerTrackMediaPartStream

            Private bitrateField As Integer

            Private bitrateModeField As String

            Private channelsField As Integer

            Private codecField As String

            Private durationField As Integer

            Private idField As Integer

            Private indexField As Integer

            Private samplingRateField As Integer

            Private selectedField As Integer

            Private streamTypeField As Integer

            Private titleField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property bitrate() As Integer
                Get
                    Return Me.bitrateField
                End Get
                Set
                    Me.bitrateField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property bitrateMode() As String
                Get
                    Return Me.bitrateModeField
                End Get
                Set
                    Me.bitrateModeField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property channels() As Integer
                Get
                    Return Me.channelsField
                End Get
                Set
                    Me.channelsField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property codec() As String
                Get
                    Return Me.codecField
                End Get
                Set
                    Me.codecField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property duration() As Integer
                Get
                    Return Me.durationField
                End Get
                Set
                    Me.durationField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property index() As Integer
                Get
                    Return Me.indexField
                End Get
                Set
                    Me.indexField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property samplingRate() As Integer
                Get
                    Return Me.samplingRateField
                End Get
                Set
                    Me.samplingRateField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property selected() As Integer
                Get
                    Return Me.selectedField
                End Get
                Set
                    Me.selectedField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property streamType() As Integer
                Get
                    Return Me.streamTypeField
                End Get
                Set
                    Me.streamTypeField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property title() As String
                Get
                    Return Me.titleField
                End Get
                Set
                    Me.titleField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerTrackUser

            Private idField As Integer

            Private thumbField As String

            Private titleField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property thumb() As String
                Get
                    Return Me.thumbField
                End Get
                Set
                    Me.thumbField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property title() As String
                Get
                    Return Me.titleField
                End Get
                Set
                    Me.titleField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerTrackPlayer

            Private machineIdentifierField As String

            Private platformField As String

            Private productField As String

            Private stateField As String

            Private titleField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property machineIdentifier() As String
                Get
                    Return Me.machineIdentifierField
                End Get
                Set
                    Me.machineIdentifierField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property platform() As String
                Get
                    Return Me.platformField
                End Get
                Set
                    Me.platformField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property product() As String
                Get
                    Return Me.productField
                End Get
                Set
                    Me.productField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property state() As String
                Get
                    Return Me.stateField
                End Get
                Set
                    Me.stateField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property title() As String
                Get
                    Return Me.titleField
                End Get
                Set
                    Me.titleField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerPhoto

            Private mediaField As MediaContainerPhotoMedia

            Private userField As MediaContainerPhotoUser

            Private playerField As MediaContainerPhotoPlayer

            Private addedAtField As Integer

            Private guidField As String

            Private indexField As Integer

            Private keyField As String

            Private librarySectionIDField As Integer

            Private originallyAvailableAtField As Date

            Private ratingKeyField As Integer

            Private sessionKeyField As Integer

            Private summaryField As String

            Private thumbField As String

            Private titleField As String

            Private typeField As String

            Private updatedAtField As Integer

            Private yearField As Integer

            '''<remarks/>
            Public Property Media() As MediaContainerPhotoMedia
                Get
                    Return Me.mediaField
                End Get
                Set
                    Me.mediaField = Value
                End Set
            End Property

            '''<remarks/>
            Public Property User() As MediaContainerPhotoUser
                Get
                    Return Me.userField
                End Get
                Set
                    Me.userField = Value
                End Set
            End Property

            '''<remarks/>
            Public Property Player() As MediaContainerPhotoPlayer
                Get
                    Return Me.playerField
                End Get
                Set
                    Me.playerField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property addedAt() As Integer
                Get
                    Return Me.addedAtField
                End Get
                Set
                    Me.addedAtField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property guid() As String
                Get
                    Return Me.guidField
                End Get
                Set
                    Me.guidField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property index() As Integer
                Get
                    Return Me.indexField
                End Get
                Set
                    Me.indexField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property key() As String
                Get
                    Return Me.keyField
                End Get
                Set
                    Me.keyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property librarySectionID() As Integer
                Get
                    Return Me.librarySectionIDField
                End Get
                Set
                    Me.librarySectionIDField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute(DataType:="date")>
            Public Property originallyAvailableAt() As Date
                Get
                    Return Me.originallyAvailableAtField
                End Get
                Set
                    Me.originallyAvailableAtField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property ratingKey() As Integer
                Get
                    Return Me.ratingKeyField
                End Get
                Set
                    Me.ratingKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property sessionKey() As Integer
                Get
                    Return Me.sessionKeyField
                End Get
                Set
                    Me.sessionKeyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property summary() As String
                Get
                    Return Me.summaryField
                End Get
                Set
                    Me.summaryField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property thumb() As String
                Get
                    Return Me.thumbField
                End Get
                Set
                    Me.thumbField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property title() As String
                Get
                    Return Me.titleField
                End Get
                Set
                    Me.titleField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property type() As String
                Get
                    Return Me.typeField
                End Get
                Set
                    Me.typeField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property updatedAt() As Integer
                Get
                    Return Me.updatedAtField
                End Get
                Set
                    Me.updatedAtField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property year() As Integer
                Get
                    Return Me.yearField
                End Get
                Set
                    Me.yearField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerPhotoMedia

            Private partField As MediaContainerPhotoMediaPart

            Private aspectRatioField As Decimal

            Private containerField As String

            Private heightField As Integer

            Private idField As Integer

            Private widthField As Integer

            '''<remarks/>
            Public Property Part() As MediaContainerPhotoMediaPart
                Get
                    Return Me.partField
                End Get
                Set
                    Me.partField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property aspectRatio() As Decimal
                Get
                    Return Me.aspectRatioField
                End Get
                Set
                    Me.aspectRatioField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property container() As String
                Get
                    Return Me.containerField
                End Get
                Set
                    Me.containerField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property height() As Integer
                Get
                    Return Me.heightField
                End Get
                Set
                    Me.heightField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property width() As Integer
                Get
                    Return Me.widthField
                End Get
                Set
                    Me.widthField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerPhotoMediaPart

            Private containerField As String

            Private fileField As String

            Private idField As Integer

            Private keyField As String

            Private sizeField As Integer

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property container() As String
                Get
                    Return Me.containerField
                End Get
                Set
                    Me.containerField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property file() As String
                Get
                    Return Me.fileField
                End Get
                Set
                    Me.fileField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property key() As String
                Get
                    Return Me.keyField
                End Get
                Set
                    Me.keyField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property size() As Integer
                Get
                    Return Me.sizeField
                End Get
                Set
                    Me.sizeField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerPhotoUser

            Private idField As Integer

            Private thumbField As String

            Private titleField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property id() As Integer
                Get
                    Return Me.idField
                End Get
                Set
                    Me.idField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property thumb() As String
                Get
                    Return Me.thumbField
                End Get
                Set
                    Me.thumbField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property title() As String
                Get
                    Return Me.titleField
                End Get
                Set
                    Me.titleField = Value
                End Set
            End Property
        End Class

        '''<remarks/>
        <System.SerializableAttribute(),
 System.ComponentModel.DesignerCategoryAttribute("code"),
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=True)>
        Partial Public Class MediaContainerPhotoPlayer

            Private machineIdentifierField As String

            Private platformField As String

            Private productField As String

            Private stateField As String

            Private titleField As String

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property machineIdentifier() As String
                Get
                    Return Me.machineIdentifierField
                End Get
                Set
                    Me.machineIdentifierField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property platform() As String
                Get
                    Return Me.platformField
                End Get
                Set
                    Me.platformField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property product() As String
                Get
                    Return Me.productField
                End Get
                Set
                    Me.productField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property state() As String
                Get
                    Return Me.stateField
                End Get
                Set
                    Me.stateField = Value
                End Set
            End Property

            '''<remarks/>
            <System.Xml.Serialization.XmlAttributeAttribute()>
            Public Property title() As String
                Get
                    Return Me.titleField
                End Get
                Set
                    Me.titleField = Value
                End Set
            End Property
        End Class

    End Class


End Namespace