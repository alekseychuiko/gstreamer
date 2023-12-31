// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

using Gst;
using Gst.Video;
using Gst.Sdp;
using Gst.Tags;
using Gst.Rtsp;
using Gst.PbUtils;
using Gst.Net;
using Gst.FFT;
using Gst.Controller;
using Gst.Base;
using Gst.Audio;
using Gst.App;
using GES;
using System;

namespace AbiTester {
	class ___Gst {
		public static void Main (string[] args) {
			Console.WriteLine("\"sizeof(GESAssetClass)\": \"" + GES.Asset.class_abi.Size + "\"");
			Console.WriteLine("\"GESAssetClass.start_loading\": \"" + GES.Asset.class_abi.GetFieldOffset("start_loading") + "\"");
			Console.WriteLine("\"GESAssetClass.extract\": \"" + GES.Asset.class_abi.GetFieldOffset("extract") + "\"");
			Console.WriteLine("\"GESAssetClass.inform_proxy\": \"" + GES.Asset.class_abi.GetFieldOffset("inform_proxy") + "\"");
			Console.WriteLine("\"GESAssetClass.proxied\": \"" + GES.Asset.class_abi.GetFieldOffset("proxied") + "\"");
			Console.WriteLine("\"GESAssetClass.request_id_update\": \"" + GES.Asset.class_abi.GetFieldOffset("request_id_update") + "\"");
			Console.WriteLine("\"sizeof(GESAsset)\": \"" + GES.Asset.abi_info.Size + "\"");
			Console.WriteLine("\"GESAsset.priv\": \"" + GES.Asset.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESAudioSourceClass)\": \"" + GES.AudioSource.class_abi.Size + "\"");
			Console.WriteLine("\"GESAudioSourceClass.create_source\": \"" + GES.AudioSource.class_abi.GetFieldOffset("create_source") + "\"");
			Console.WriteLine("\"sizeof(GESAudioSource)\": \"" + GES.AudioSource.abi_info.Size + "\"");
			Console.WriteLine("\"GESAudioSource.priv\": \"" + GES.AudioSource.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESAudioTestSourceClass)\": \"" + GES.AudioTestSource.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESAudioTestSource)\": \"" + GES.AudioTestSource.abi_info.Size + "\"");
			Console.WriteLine("\"GESAudioTestSource.priv\": \"" + GES.AudioTestSource.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESAudioTrackClass)\": \"" + GES.AudioTrack.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESAudioTrack)\": \"" + GES.AudioTrack.abi_info.Size + "\"");
			Console.WriteLine("\"GESAudioTrack.priv\": \"" + GES.AudioTrack.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESAudioTransitionClass)\": \"" + GES.AudioTransition.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESAudioTransition)\": \"" + GES.AudioTransition.abi_info.Size + "\"");
			Console.WriteLine("\"GESAudioTransition.priv\": \"" + GES.AudioTransition.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESAudioUriSourceClass)\": \"" + GES.AudioUriSource.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESAudioUriSource)\": \"" + GES.AudioUriSource.abi_info.Size + "\"");
			Console.WriteLine("\"GESAudioUriSource.uri\": \"" + GES.AudioUriSource.abi_info.GetFieldOffset("uri") + "\"");
			Console.WriteLine("\"GESAudioUriSource.priv\": \"" + GES.AudioUriSource.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESBaseEffectClass)\": \"" + GES.BaseEffect.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESBaseEffect)\": \"" + GES.BaseEffect.abi_info.Size + "\"");
			Console.WriteLine("\"GESBaseEffect.priv\": \"" + GES.BaseEffect.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESBaseEffectClipClass)\": \"" + GES.BaseEffectClip.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESBaseEffectClip)\": \"" + GES.BaseEffectClip.abi_info.Size + "\"");
			Console.WriteLine("\"GESBaseEffectClip.priv\": \"" + GES.BaseEffectClip.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESBaseTransitionClipClass)\": \"" + GES.BaseTransitionClip.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESBaseTransitionClip)\": \"" + GES.BaseTransitionClip.abi_info.Size + "\"");
			Console.WriteLine("\"GESBaseTransitionClip.priv\": \"" + GES.BaseTransitionClip.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESBaseXmlFormatterClass)\": \"" + GES.BaseXmlFormatter.class_abi.Size + "\"");
			Console.WriteLine("\"GESBaseXmlFormatterClass.content_parser\": \"" + GES.BaseXmlFormatter.class_abi.GetFieldOffset("content_parser") + "\"");
			Console.WriteLine("\"GESBaseXmlFormatterClass.save\": \"" + GES.BaseXmlFormatter.class_abi.GetFieldOffset("save") + "\"");
			Console.WriteLine("\"sizeof(GESBaseXmlFormatter)\": \"" + GES.BaseXmlFormatter.abi_info.Size + "\"");
			Console.WriteLine("\"GESBaseXmlFormatter.priv\": \"" + GES.BaseXmlFormatter.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"GESBaseXmlFormatter.xmlcontent\": \"" + GES.BaseXmlFormatter.abi_info.GetFieldOffset("xmlcontent") + "\"");
			Console.WriteLine("\"sizeof(GESClipClass)\": \"" + GES.Clip.class_abi.Size + "\"");
			Console.WriteLine("\"GESClipClass.create_track_element\": \"" + GES.Clip.class_abi.GetFieldOffset("create_track_element") + "\"");
			Console.WriteLine("\"GESClipClass.create_track_elements\": \"" + GES.Clip.class_abi.GetFieldOffset("create_track_elements") + "\"");
			Console.WriteLine("\"sizeof(GESClip)\": \"" + GES.Clip.abi_info.Size + "\"");
			Console.WriteLine("\"GESClip.priv\": \"" + GES.Clip.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESClipAssetClass)\": \"" + GES.ClipAsset.class_abi.Size + "\"");
			Console.WriteLine("\"GESClipAssetClass.get_natural_framerate\": \"" + GES.ClipAsset.class_abi.GetFieldOffset("get_natural_framerate") + "\"");
			Console.WriteLine("\"sizeof(GESClipAsset)\": \"" + GES.ClipAsset.abi_info.Size + "\"");
			Console.WriteLine("\"GESClipAsset.priv\": \"" + GES.ClipAsset.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESCommandLineFormatter)\": \"" + GES.CommandLineFormatter.abi_info.Size + "\"");
			Console.WriteLine("\"GESCommandLineFormatter.priv\": \"" + GES.CommandLineFormatter.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESContainerClass)\": \"" + GES.Container.class_abi.Size + "\"");
			Console.WriteLine("\"GESContainerClass.child_added\": \"" + GES.Container.class_abi.GetFieldOffset("child_added") + "\"");
			Console.WriteLine("\"GESContainerClass.child_removed\": \"" + GES.Container.class_abi.GetFieldOffset("child_removed") + "\"");
			Console.WriteLine("\"GESContainerClass.add_child\": \"" + GES.Container.class_abi.GetFieldOffset("add_child") + "\"");
			Console.WriteLine("\"GESContainerClass.remove_child\": \"" + GES.Container.class_abi.GetFieldOffset("remove_child") + "\"");
			Console.WriteLine("\"GESContainerClass.ungroup\": \"" + GES.Container.class_abi.GetFieldOffset("ungroup") + "\"");
			Console.WriteLine("\"GESContainerClass.group\": \"" + GES.Container.class_abi.GetFieldOffset("group") + "\"");
			Console.WriteLine("\"GESContainerClass.edit\": \"" + GES.Container.class_abi.GetFieldOffset("edit") + "\"");
			Console.WriteLine("\"GESContainerClass.grouping_priority\": \"" + GES.Container.class_abi.GetFieldOffset("grouping_priority") + "\"");
			Console.WriteLine("\"sizeof(GESContainer)\": \"" + GES.Container.abi_info.Size + "\"");
			Console.WriteLine("\"GESContainer.children\": \"" + GES.Container.abi_info.GetFieldOffset("children") + "\"");
			Console.WriteLine("\"GESContainer.height\": \"" + GES.Container.abi_info.GetFieldOffset("height") + "\"");
			Console.WriteLine("\"GESContainer.children_control_mode\": \"" + GES.Container.abi_info.GetFieldOffset("children_control_mode") + "\"");
			Console.WriteLine("\"GESContainer.initiated_move\": \"" + GES.Container.abi_info.GetFieldOffset("initiated_move") + "\"");
			Console.WriteLine("\"GESContainer.priv\": \"" + GES.Container.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESEffectClass)\": \"" + GES.Effect.class_abi.Size + "\"");
			Console.WriteLine("\"GESEffectClass.rate_properties\": \"" + GES.Effect.class_abi.GetFieldOffset("rate_properties") + "\"");
			Console.WriteLine("\"sizeof(GESEffect)\": \"" + GES.Effect.abi_info.Size + "\"");
			Console.WriteLine("\"GESEffect.priv\": \"" + GES.Effect.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESEffectClipClass)\": \"" + GES.EffectClip.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESEffectClip)\": \"" + GES.EffectClip.abi_info.Size + "\"");
			Console.WriteLine("\"GESEffectClip.priv\": \"" + GES.EffectClip.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESFormatterClass)\": \"" + GES.Formatter.class_abi.Size + "\"");
			Console.WriteLine("\"GESFormatterClass.can_load_uri\": \"" + GES.Formatter.class_abi.GetFieldOffset("can_load_uri") + "\"");
			Console.WriteLine("\"GESFormatterClass.load_from_uri\": \"" + GES.Formatter.class_abi.GetFieldOffset("load_from_uri") + "\"");
			Console.WriteLine("\"GESFormatterClass.save_to_uri\": \"" + GES.Formatter.class_abi.GetFieldOffset("save_to_uri") + "\"");
			Console.WriteLine("\"GESFormatterClass.name\": \"" + GES.Formatter.class_abi.GetFieldOffset("name") + "\"");
			Console.WriteLine("\"GESFormatterClass.description\": \"" + GES.Formatter.class_abi.GetFieldOffset("description") + "\"");
			Console.WriteLine("\"GESFormatterClass.extension\": \"" + GES.Formatter.class_abi.GetFieldOffset("extension") + "\"");
			Console.WriteLine("\"GESFormatterClass.mimetype\": \"" + GES.Formatter.class_abi.GetFieldOffset("mimetype") + "\"");
			Console.WriteLine("\"GESFormatterClass.version\": \"" + GES.Formatter.class_abi.GetFieldOffset("version") + "\"");
			Console.WriteLine("\"GESFormatterClass.rank\": \"" + GES.Formatter.class_abi.GetFieldOffset("rank") + "\"");
			Console.WriteLine("\"sizeof(GESFormatter)\": \"" + GES.Formatter.abi_info.Size + "\"");
			Console.WriteLine("\"GESFormatter.priv\": \"" + GES.Formatter.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"GESFormatter.project\": \"" + GES.Formatter.abi_info.GetFieldOffset("project") + "\"");
			Console.WriteLine("\"GESFormatter.timeline\": \"" + GES.Formatter.abi_info.GetFieldOffset("timeline") + "\"");
			Console.WriteLine("\"sizeof(GESGroupClass)\": \"" + GES.Group.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESGroup)\": \"" + GES.Group.abi_info.Size + "\"");
			Console.WriteLine("\"GESGroup.priv\": \"" + GES.Group.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESImageSourceClass)\": \"" + GES.ImageSource.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESImageSource)\": \"" + GES.ImageSource.abi_info.Size + "\"");
			Console.WriteLine("\"GESImageSource.uri\": \"" + GES.ImageSource.abi_info.GetFieldOffset("uri") + "\"");
			Console.WriteLine("\"GESImageSource.priv\": \"" + GES.ImageSource.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESLayerClass)\": \"" + GES.Layer.class_abi.Size + "\"");
			Console.WriteLine("\"GESLayerClass.get_objects\": \"" + GES.Layer.class_abi.GetFieldOffset("get_objects") + "\"");
			Console.WriteLine("\"GESLayerClass.object_added\": \"" + GES.Layer.class_abi.GetFieldOffset("object_added") + "\"");
			Console.WriteLine("\"GESLayerClass.object_removed\": \"" + GES.Layer.class_abi.GetFieldOffset("object_removed") + "\"");
			Console.WriteLine("\"sizeof(GESLayer)\": \"" + GES.Layer.abi_info.Size + "\"");
			Console.WriteLine("\"GESLayer.timeline\": \"" + GES.Layer.abi_info.GetFieldOffset("timeline") + "\"");
			Console.WriteLine("\"GESLayer.min_nle_priority\": \"" + GES.Layer.abi_info.GetFieldOffset("min_nle_priority") + "\"");
			Console.WriteLine("\"GESLayer.max_nle_priority\": \"" + GES.Layer.abi_info.GetFieldOffset("max_nle_priority") + "\"");
			Console.WriteLine("\"GESLayer.priv\": \"" + GES.Layer.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESMultiFileSourceClass)\": \"" + GES.MultiFileSource.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESMultiFileSource)\": \"" + GES.MultiFileSource.abi_info.Size + "\"");
			Console.WriteLine("\"GESMultiFileSource.uri\": \"" + GES.MultiFileSource.abi_info.GetFieldOffset("uri") + "\"");
			Console.WriteLine("\"GESMultiFileSource.priv\": \"" + GES.MultiFileSource.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESOperationClass)\": \"" + GES.Operation.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESOperation)\": \"" + GES.Operation.abi_info.Size + "\"");
			Console.WriteLine("\"GESOperation.priv\": \"" + GES.Operation.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESOperationClipClass)\": \"" + GES.OperationClip.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESOperationClip)\": \"" + GES.OperationClip.abi_info.Size + "\"");
			Console.WriteLine("\"GESOperationClip.priv\": \"" + GES.OperationClip.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESOverlayClipClass)\": \"" + GES.OverlayClip.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESOverlayClip)\": \"" + GES.OverlayClip.abi_info.Size + "\"");
			Console.WriteLine("\"GESOverlayClip.priv\": \"" + GES.OverlayClip.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESPipelineClass)\": \"" + GES.Pipeline.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESPipeline)\": \"" + GES.Pipeline.abi_info.Size + "\"");
			Console.WriteLine("\"GESPipeline.priv\": \"" + GES.Pipeline.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESProjectClass)\": \"" + GES.Project.class_abi.Size + "\"");
			Console.WriteLine("\"GESProjectClass.asset_added\": \"" + GES.Project.class_abi.GetFieldOffset("asset_added") + "\"");
			Console.WriteLine("\"GESProjectClass.asset_loading\": \"" + GES.Project.class_abi.GetFieldOffset("asset_loading") + "\"");
			Console.WriteLine("\"GESProjectClass.asset_removed\": \"" + GES.Project.class_abi.GetFieldOffset("asset_removed") + "\"");
			Console.WriteLine("\"GESProjectClass.missing_uri\": \"" + GES.Project.class_abi.GetFieldOffset("missing_uri") + "\"");
			Console.WriteLine("\"GESProjectClass.loading_error\": \"" + GES.Project.class_abi.GetFieldOffset("loading_error") + "\"");
			Console.WriteLine("\"GESProjectClass.loaded\": \"" + GES.Project.class_abi.GetFieldOffset("loaded") + "\"");
			Console.WriteLine("\"GESProjectClass.loading\": \"" + GES.Project.class_abi.GetFieldOffset("loading") + "\"");
			Console.WriteLine("\"sizeof(GESProject)\": \"" + GES.Project.abi_info.Size + "\"");
			Console.WriteLine("\"GESProject.priv\": \"" + GES.Project.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESSourceClass)\": \"" + GES.Source.class_abi.Size + "\"");
			Console.WriteLine("\"GESSourceClass.select_pad\": \"" + GES.Source.class_abi.GetFieldOffset("select_pad") + "\"");
			Console.WriteLine("\"GESSourceClass.create_source\": \"" + GES.Source.class_abi.GetFieldOffset("create_source") + "\"");
			Console.WriteLine("\"sizeof(GESSource)\": \"" + GES.Source.abi_info.Size + "\"");
			Console.WriteLine("\"GESSource.priv\": \"" + GES.Source.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESSourceClipClass)\": \"" + GES.SourceClip.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESSourceClip)\": \"" + GES.SourceClip.abi_info.Size + "\"");
			Console.WriteLine("\"GESSourceClip.priv\": \"" + GES.SourceClip.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESTestClipClass)\": \"" + GES.TestClip.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESTestClip)\": \"" + GES.TestClip.abi_info.Size + "\"");
			Console.WriteLine("\"GESTestClip.priv\": \"" + GES.TestClip.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESTextOverlayClass)\": \"" + GES.TextOverlay.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESTextOverlay)\": \"" + GES.TextOverlay.abi_info.Size + "\"");
			Console.WriteLine("\"GESTextOverlay.priv\": \"" + GES.TextOverlay.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESTextOverlayClipClass)\": \"" + GES.TextOverlayClip.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESTextOverlayClip)\": \"" + GES.TextOverlayClip.abi_info.Size + "\"");
			Console.WriteLine("\"GESTextOverlayClip.priv\": \"" + GES.TextOverlayClip.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESTimelineClass)\": \"" + GES.Timeline.class_abi.Size + "\"");
			Console.WriteLine("\"GESTimelineClass.track_added\": \"" + GES.Timeline.class_abi.GetFieldOffset("track_added") + "\"");
			Console.WriteLine("\"GESTimelineClass.track_removed\": \"" + GES.Timeline.class_abi.GetFieldOffset("track_removed") + "\"");
			Console.WriteLine("\"GESTimelineClass.layer_added\": \"" + GES.Timeline.class_abi.GetFieldOffset("layer_added") + "\"");
			Console.WriteLine("\"GESTimelineClass.layer_removed\": \"" + GES.Timeline.class_abi.GetFieldOffset("layer_removed") + "\"");
			Console.WriteLine("\"GESTimelineClass.group_added\": \"" + GES.Timeline.class_abi.GetFieldOffset("group_added") + "\"");
			Console.WriteLine("\"GESTimelineClass.group_removed\": \"" + GES.Timeline.class_abi.GetFieldOffset("group_removed") + "\"");
			Console.WriteLine("\"sizeof(GESTimeline)\": \"" + GES.Timeline.abi_info.Size + "\"");
			Console.WriteLine("\"GESTimeline.layers\": \"" + GES.Timeline.abi_info.GetFieldOffset("layers") + "\"");
			Console.WriteLine("\"GESTimeline.tracks\": \"" + GES.Timeline.abi_info.GetFieldOffset("tracks") + "\"");
			Console.WriteLine("\"GESTimeline.priv\": \"" + GES.Timeline.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESTimelineElementClass)\": \"" + GES.TimelineElement.class_abi.Size + "\"");
			Console.WriteLine("\"GESTimelineElementClass.set_parent\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("set_parent") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.set_start\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("set_start") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.set_inpoint\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("set_inpoint") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.set_duration\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("set_duration") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.set_max_duration\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("set_max_duration") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.set_priority\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("set_priority") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.ripple\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("ripple") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.ripple_end\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("ripple_end") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.roll_start\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("roll_start") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.roll_end\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("roll_end") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.trim\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("trim") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.deep_copy\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("deep_copy") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.paste\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("paste") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.list_children_properties\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("list_children_properties") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.lookup_child\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("lookup_child") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.get_track_types\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("get_track_types") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.set_child_property\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("set_child_property") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.get_layer_priority\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("get_layer_priority") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.get_natural_framerate\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("get_natural_framerate") + "\"");
			Console.WriteLine("\"GESTimelineElementClass.set_child_property_full\": \"" + GES.TimelineElement.class_abi.GetFieldOffset("set_child_property_full") + "\"");
			Console.WriteLine("\"sizeof(GESTimelineElement)\": \"" + GES.TimelineElement.abi_info.Size + "\"");
			Console.WriteLine("\"GESTimelineElement.parent\": \"" + GES.TimelineElement.abi_info.GetFieldOffset("parent") + "\"");
			Console.WriteLine("\"GESTimelineElement.asset\": \"" + GES.TimelineElement.abi_info.GetFieldOffset("asset") + "\"");
			Console.WriteLine("\"GESTimelineElement.start\": \"" + GES.TimelineElement.abi_info.GetFieldOffset("start") + "\"");
			Console.WriteLine("\"GESTimelineElement.inpoint\": \"" + GES.TimelineElement.abi_info.GetFieldOffset("inpoint") + "\"");
			Console.WriteLine("\"GESTimelineElement.duration\": \"" + GES.TimelineElement.abi_info.GetFieldOffset("duration") + "\"");
			Console.WriteLine("\"GESTimelineElement.maxduration\": \"" + GES.TimelineElement.abi_info.GetFieldOffset("maxduration") + "\"");
			Console.WriteLine("\"GESTimelineElement.priority\": \"" + GES.TimelineElement.abi_info.GetFieldOffset("priority") + "\"");
			Console.WriteLine("\"GESTimelineElement.timeline\": \"" + GES.TimelineElement.abi_info.GetFieldOffset("timeline") + "\"");
			Console.WriteLine("\"GESTimelineElement.name\": \"" + GES.TimelineElement.abi_info.GetFieldOffset("name") + "\"");
			Console.WriteLine("\"GESTimelineElement.priv\": \"" + GES.TimelineElement.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESTitleClipClass)\": \"" + GES.TitleClip.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESTitleClip)\": \"" + GES.TitleClip.abi_info.Size + "\"");
			Console.WriteLine("\"GESTitleClip.priv\": \"" + GES.TitleClip.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESTitleSourceClass)\": \"" + GES.TitleSource.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESTitleSource)\": \"" + GES.TitleSource.abi_info.Size + "\"");
			Console.WriteLine("\"GESTitleSource.priv\": \"" + GES.TitleSource.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESTrackClass)\": \"" + GES.Track.class_abi.Size + "\"");
			Console.WriteLine("\"GESTrackClass.get_mixing_element\": \"" + GES.Track.class_abi.GetFieldOffset("get_mixing_element") + "\"");
			Console.WriteLine("\"sizeof(GESTrack)\": \"" + GES.Track.abi_info.Size + "\"");
			Console.WriteLine("\"GESTrack.type\": \"" + GES.Track.abi_info.GetFieldOffset("type") + "\"");
			Console.WriteLine("\"GESTrack.priv\": \"" + GES.Track.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESTrackElementClass)\": \"" + GES.TrackElement.class_abi.Size + "\"");
			Console.WriteLine("\"GESTrackElementClass.nleobject_factorytype\": \"" + GES.TrackElement.class_abi.GetFieldOffset("nleobject_factorytype") + "\"");
			Console.WriteLine("\"GESTrackElementClass.create_gnl_object\": \"" + GES.TrackElement.class_abi.GetFieldOffset("create_gnl_object") + "\"");
			Console.WriteLine("\"GESTrackElementClass.create_element\": \"" + GES.TrackElement.class_abi.GetFieldOffset("create_element") + "\"");
			Console.WriteLine("\"GESTrackElementClass.active_changed\": \"" + GES.TrackElement.class_abi.GetFieldOffset("active_changed") + "\"");
			Console.WriteLine("\"GESTrackElementClass.changed\": \"" + GES.TrackElement.class_abi.GetFieldOffset("changed") + "\"");
			Console.WriteLine("\"GESTrackElementClass.list_children_properties\": \"" + GES.TrackElement.class_abi.GetFieldOffset("list_children_properties") + "\"");
			Console.WriteLine("\"GESTrackElementClass.lookup_child\": \"" + GES.TrackElement.class_abi.GetFieldOffset("lookup_child") + "\"");
			Console.WriteLine("\"sizeof(GESTrackElement)\": \"" + GES.TrackElement.abi_info.Size + "\"");
			Console.WriteLine("\"GESTrackElement.active\": \"" + GES.TrackElement.abi_info.GetFieldOffset("active") + "\"");
			Console.WriteLine("\"GESTrackElement.priv\": \"" + GES.TrackElement.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"GESTrackElement.asset\": \"" + GES.TrackElement.abi_info.GetFieldOffset("asset") + "\"");
			Console.WriteLine("\"sizeof(GESTrackElementAssetClass)\": \"" + GES.TrackElementAsset.class_abi.Size + "\"");
			Console.WriteLine("\"GESTrackElementAssetClass.get_natural_framerate\": \"" + GES.TrackElementAsset.class_abi.GetFieldOffset("get_natural_framerate") + "\"");
			Console.WriteLine("\"sizeof(GESTrackElementAsset)\": \"" + GES.TrackElementAsset.abi_info.Size + "\"");
			Console.WriteLine("\"GESTrackElementAsset.priv\": \"" + GES.TrackElementAsset.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESTransitionClass)\": \"" + GES.Transition.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESTransition)\": \"" + GES.Transition.abi_info.Size + "\"");
			Console.WriteLine("\"GESTransition.priv\": \"" + GES.Transition.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESTransitionClipClass)\": \"" + GES.TransitionClip.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESTransitionClip)\": \"" + GES.TransitionClip.abi_info.Size + "\"");
			Console.WriteLine("\"GESTransitionClip.vtype\": \"" + GES.TransitionClip.abi_info.GetFieldOffset("vtype") + "\"");
			Console.WriteLine("\"GESTransitionClip.priv\": \"" + GES.TransitionClip.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESUriClipClass)\": \"" + GES.UriClip.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESUriClip)\": \"" + GES.UriClip.abi_info.Size + "\"");
			Console.WriteLine("\"GESUriClip.priv\": \"" + GES.UriClip.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESUriClipAssetClass)\": \"" + GES.UriClipAsset.class_abi.Size + "\"");
			Console.WriteLine("\"GESUriClipAssetClass.discoverer\": \"" + GES.UriClipAsset.class_abi.GetFieldOffset("discoverer") + "\"");
			Console.WriteLine("\"GESUriClipAssetClass.sync_discoverer\": \"" + GES.UriClipAsset.class_abi.GetFieldOffset("sync_discoverer") + "\"");
			Console.WriteLine("\"GESUriClipAssetClass.discovered\": \"" + GES.UriClipAsset.class_abi.GetFieldOffset("discovered") + "\"");
			Console.WriteLine("\"sizeof(GESUriClipAsset)\": \"" + GES.UriClipAsset.abi_info.Size + "\"");
			Console.WriteLine("\"GESUriClipAsset.priv\": \"" + GES.UriClipAsset.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESUriSourceAssetClass)\": \"" + GES.UriSourceAsset.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESUriSourceAsset)\": \"" + GES.UriSourceAsset.abi_info.Size + "\"");
			Console.WriteLine("\"GESUriSourceAsset.priv\": \"" + GES.UriSourceAsset.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESVideoSourceClass)\": \"" + GES.VideoSource.class_abi.Size + "\"");
			Console.WriteLine("\"GESVideoSourceClass.create_source\": \"" + GES.VideoSource.class_abi.GetFieldOffset("create_source") + "\"");
			Console.WriteLine("\"sizeof(GESVideoSource)\": \"" + GES.VideoSource.abi_info.Size + "\"");
			Console.WriteLine("\"GESVideoSource.priv\": \"" + GES.VideoSource.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESVideoTestSourceClass)\": \"" + GES.VideoTestSource.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESVideoTestSource)\": \"" + GES.VideoTestSource.abi_info.Size + "\"");
			Console.WriteLine("\"GESVideoTestSource.priv\": \"" + GES.VideoTestSource.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESVideoTrackClass)\": \"" + GES.VideoTrack.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESVideoTrack)\": \"" + GES.VideoTrack.abi_info.Size + "\"");
			Console.WriteLine("\"GESVideoTrack.priv\": \"" + GES.VideoTrack.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESVideoTransitionClass)\": \"" + GES.VideoTransition.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESVideoTransition)\": \"" + GES.VideoTransition.abi_info.Size + "\"");
			Console.WriteLine("\"GESVideoTransition.priv\": \"" + GES.VideoTransition.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESVideoUriSourceClass)\": \"" + GES.VideoUriSource.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESVideoUriSource)\": \"" + GES.VideoUriSource.abi_info.Size + "\"");
			Console.WriteLine("\"GESVideoUriSource.uri\": \"" + GES.VideoUriSource.abi_info.GetFieldOffset("uri") + "\"");
			Console.WriteLine("\"GESVideoUriSource.priv\": \"" + GES.VideoUriSource.abi_info.GetFieldOffset("priv") + "\"");
			Console.WriteLine("\"sizeof(GESXmlFormatterClass)\": \"" + GES.XmlFormatter.class_abi.Size + "\"");
			Console.WriteLine("\"sizeof(GESXmlFormatter)\": \"" + GES.XmlFormatter.abi_info.Size + "\"");
			Console.WriteLine("\"GESXmlFormatter.priv\": \"" + GES.XmlFormatter.abi_info.GetFieldOffset("priv") + "\"");
		}
	}
}
