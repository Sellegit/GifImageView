using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Felipecsl.Gifimageview.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']"
	[global::Android.Runtime.Register ("com/felipecsl/gifimageview/library/GifDecoder", DoNotGenerateAcw=true)]
	public partial class GifDecoder : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='MAX_STACK_SIZE']"
		[Register ("MAX_STACK_SIZE")]
		protected const int MaxStackSize = (int) 4096;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='STATUS_FORMAT_ERROR']"
		[Register ("STATUS_FORMAT_ERROR")]
		public const int StatusFormatError = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='STATUS_OK']"
		[Register ("STATUS_OK")]
		public const int StatusOk = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='STATUS_OPEN_ERROR']"
		[Register ("STATUS_OPEN_ERROR")]
		public const int StatusOpenError = (int) 2;

		static IntPtr act_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='act']"
		[Register ("act")]
		protected IList<int> Act {
			get {
				if (act_jfieldId == IntPtr.Zero)
					act_jfieldId = JNIEnv.GetFieldID (class_ref, "act", "[I");
				return JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (Handle, act_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (act_jfieldId == IntPtr.Zero)
					act_jfieldId = JNIEnv.GetFieldID (class_ref, "act", "[I");
				IntPtr native_value = JavaArray<int>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, act_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr bgColor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='bgColor']"
		[Register ("bgColor")]
		protected int BgColor {
			get {
				if (bgColor_jfieldId == IntPtr.Zero)
					bgColor_jfieldId = JNIEnv.GetFieldID (class_ref, "bgColor", "I");
				return JNIEnv.GetIntField (Handle, bgColor_jfieldId);
			}
			set {
				if (bgColor_jfieldId == IntPtr.Zero)
					bgColor_jfieldId = JNIEnv.GetFieldID (class_ref, "bgColor", "I");
				JNIEnv.SetField (Handle, bgColor_jfieldId, value);
			}
		}

		static IntPtr bgIndex_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='bgIndex']"
		[Register ("bgIndex")]
		protected int BgIndex {
			get {
				if (bgIndex_jfieldId == IntPtr.Zero)
					bgIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "bgIndex", "I");
				return JNIEnv.GetIntField (Handle, bgIndex_jfieldId);
			}
			set {
				if (bgIndex_jfieldId == IntPtr.Zero)
					bgIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "bgIndex", "I");
				JNIEnv.SetField (Handle, bgIndex_jfieldId, value);
			}
		}

		static IntPtr block_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='block']"
		[Register ("block")]
		protected IList<byte> Block {
			get {
				if (block_jfieldId == IntPtr.Zero)
					block_jfieldId = JNIEnv.GetFieldID (class_ref, "block", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, block_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (block_jfieldId == IntPtr.Zero)
					block_jfieldId = JNIEnv.GetFieldID (class_ref, "block", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, block_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr blockSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='blockSize']"
		[Register ("blockSize")]
		protected int BlockSize {
			get {
				if (blockSize_jfieldId == IntPtr.Zero)
					blockSize_jfieldId = JNIEnv.GetFieldID (class_ref, "blockSize", "I");
				return JNIEnv.GetIntField (Handle, blockSize_jfieldId);
			}
			set {
				if (blockSize_jfieldId == IntPtr.Zero)
					blockSize_jfieldId = JNIEnv.GetFieldID (class_ref, "blockSize", "I");
				JNIEnv.SetField (Handle, blockSize_jfieldId, value);
			}
		}

		static IntPtr copyScratch_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='copyScratch']"
		[Register ("copyScratch")]
		protected IList<int> CopyScratch {
			get {
				if (copyScratch_jfieldId == IntPtr.Zero)
					copyScratch_jfieldId = JNIEnv.GetFieldID (class_ref, "copyScratch", "[I");
				return JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (Handle, copyScratch_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (copyScratch_jfieldId == IntPtr.Zero)
					copyScratch_jfieldId = JNIEnv.GetFieldID (class_ref, "copyScratch", "[I");
				IntPtr native_value = JavaArray<int>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, copyScratch_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr currentFrame_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='currentFrame']"
		[Register ("currentFrame")]
		protected global::Com.Felipecsl.Gifimageview.Library.GifDecoder.GifFrame CurrentFrame {
			get {
				if (currentFrame_jfieldId == IntPtr.Zero)
					currentFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "currentFrame", "Lcom/felipecsl/gifimageview/library/GifDecoder$GifFrame;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, currentFrame_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder.GifFrame> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (currentFrame_jfieldId == IntPtr.Zero)
					currentFrame_jfieldId = JNIEnv.GetFieldID (class_ref, "currentFrame", "Lcom/felipecsl/gifimageview/library/GifDecoder$GifFrame;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, currentFrame_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr currentImage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='currentImage']"
		[Register ("currentImage")]
		protected global::Android.Graphics.Bitmap CurrentImage {
			get {
				if (currentImage_jfieldId == IntPtr.Zero)
					currentImage_jfieldId = JNIEnv.GetFieldID (class_ref, "currentImage", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, currentImage_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (currentImage_jfieldId == IntPtr.Zero)
					currentImage_jfieldId = JNIEnv.GetFieldID (class_ref, "currentImage", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, currentImage_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr framePointer_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='framePointer']"
		[Register ("framePointer")]
		protected int FramePointer {
			get {
				if (framePointer_jfieldId == IntPtr.Zero)
					framePointer_jfieldId = JNIEnv.GetFieldID (class_ref, "framePointer", "I");
				return JNIEnv.GetIntField (Handle, framePointer_jfieldId);
			}
			set {
				if (framePointer_jfieldId == IntPtr.Zero)
					framePointer_jfieldId = JNIEnv.GetFieldID (class_ref, "framePointer", "I");
				JNIEnv.SetField (Handle, framePointer_jfieldId, value);
			}
		}

		static IntPtr frames_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='frames']"
		[Register ("frames")]
		protected global::System.Collections.IList Frames {
			get {
				if (frames_jfieldId == IntPtr.Zero)
					frames_jfieldId = JNIEnv.GetFieldID (class_ref, "frames", "Ljava/util/ArrayList;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, frames_jfieldId);
				return global::Android.Runtime.JavaList.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (frames_jfieldId == IntPtr.Zero)
					frames_jfieldId = JNIEnv.GetFieldID (class_ref, "frames", "Ljava/util/ArrayList;");
				IntPtr native_value = global::Android.Runtime.JavaList.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, frames_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr gct_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='gct']"
		[Register ("gct")]
		protected IList<int> Gct {
			get {
				if (gct_jfieldId == IntPtr.Zero)
					gct_jfieldId = JNIEnv.GetFieldID (class_ref, "gct", "[I");
				return JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (Handle, gct_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (gct_jfieldId == IntPtr.Zero)
					gct_jfieldId = JNIEnv.GetFieldID (class_ref, "gct", "[I");
				IntPtr native_value = JavaArray<int>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, gct_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr gctFlag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='gctFlag']"
		[Register ("gctFlag")]
		protected bool GctFlag {
			get {
				if (gctFlag_jfieldId == IntPtr.Zero)
					gctFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "gctFlag", "Z");
				return JNIEnv.GetBooleanField (Handle, gctFlag_jfieldId);
			}
			set {
				if (gctFlag_jfieldId == IntPtr.Zero)
					gctFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "gctFlag", "Z");
				JNIEnv.SetField (Handle, gctFlag_jfieldId, value);
			}
		}

		static IntPtr gctSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='gctSize']"
		[Register ("gctSize")]
		protected int GctSize {
			get {
				if (gctSize_jfieldId == IntPtr.Zero)
					gctSize_jfieldId = JNIEnv.GetFieldID (class_ref, "gctSize", "I");
				return JNIEnv.GetIntField (Handle, gctSize_jfieldId);
			}
			set {
				if (gctSize_jfieldId == IntPtr.Zero)
					gctSize_jfieldId = JNIEnv.GetFieldID (class_ref, "gctSize", "I");
				JNIEnv.SetField (Handle, gctSize_jfieldId, value);
			}
		}

		static IntPtr height_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='height']"
		[Register ("height")]
		protected int Height {
			get {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				return JNIEnv.GetIntField (Handle, height_jfieldId);
			}
			set {
				if (height_jfieldId == IntPtr.Zero)
					height_jfieldId = JNIEnv.GetFieldID (class_ref, "height", "I");
				JNIEnv.SetField (Handle, height_jfieldId, value);
			}
		}

		static IntPtr lctFlag_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='lctFlag']"
		[Register ("lctFlag")]
		protected bool LctFlag {
			get {
				if (lctFlag_jfieldId == IntPtr.Zero)
					lctFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "lctFlag", "Z");
				return JNIEnv.GetBooleanField (Handle, lctFlag_jfieldId);
			}
			set {
				if (lctFlag_jfieldId == IntPtr.Zero)
					lctFlag_jfieldId = JNIEnv.GetFieldID (class_ref, "lctFlag", "Z");
				JNIEnv.SetField (Handle, lctFlag_jfieldId, value);
			}
		}

		static IntPtr lctSize_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='lctSize']"
		[Register ("lctSize")]
		protected int LctSize {
			get {
				if (lctSize_jfieldId == IntPtr.Zero)
					lctSize_jfieldId = JNIEnv.GetFieldID (class_ref, "lctSize", "I");
				return JNIEnv.GetIntField (Handle, lctSize_jfieldId);
			}
			set {
				if (lctSize_jfieldId == IntPtr.Zero)
					lctSize_jfieldId = JNIEnv.GetFieldID (class_ref, "lctSize", "I");
				JNIEnv.SetField (Handle, lctSize_jfieldId, value);
			}
		}

		static IntPtr mainPixels_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='mainPixels']"
		[Register ("mainPixels")]
		protected IList<byte> MainPixels {
			get {
				if (mainPixels_jfieldId == IntPtr.Zero)
					mainPixels_jfieldId = JNIEnv.GetFieldID (class_ref, "mainPixels", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, mainPixels_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mainPixels_jfieldId == IntPtr.Zero)
					mainPixels_jfieldId = JNIEnv.GetFieldID (class_ref, "mainPixels", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mainPixels_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr mainScratch_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='mainScratch']"
		[Register ("mainScratch")]
		protected IList<int> MainScratch {
			get {
				if (mainScratch_jfieldId == IntPtr.Zero)
					mainScratch_jfieldId = JNIEnv.GetFieldID (class_ref, "mainScratch", "[I");
				return JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (Handle, mainScratch_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mainScratch_jfieldId == IntPtr.Zero)
					mainScratch_jfieldId = JNIEnv.GetFieldID (class_ref, "mainScratch", "[I");
				IntPtr native_value = JavaArray<int>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mainScratch_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr pixelAspect_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='pixelAspect']"
		[Register ("pixelAspect")]
		protected int PixelAspect {
			get {
				if (pixelAspect_jfieldId == IntPtr.Zero)
					pixelAspect_jfieldId = JNIEnv.GetFieldID (class_ref, "pixelAspect", "I");
				return JNIEnv.GetIntField (Handle, pixelAspect_jfieldId);
			}
			set {
				if (pixelAspect_jfieldId == IntPtr.Zero)
					pixelAspect_jfieldId = JNIEnv.GetFieldID (class_ref, "pixelAspect", "I");
				JNIEnv.SetField (Handle, pixelAspect_jfieldId, value);
			}
		}

		static IntPtr pixelStack_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='pixelStack']"
		[Register ("pixelStack")]
		protected IList<byte> PixelStack {
			get {
				if (pixelStack_jfieldId == IntPtr.Zero)
					pixelStack_jfieldId = JNIEnv.GetFieldID (class_ref, "pixelStack", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, pixelStack_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (pixelStack_jfieldId == IntPtr.Zero)
					pixelStack_jfieldId = JNIEnv.GetFieldID (class_ref, "pixelStack", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, pixelStack_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr prefix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='prefix']"
		[Register ("prefix")]
		protected IList<short> Prefix {
			get {
				if (prefix_jfieldId == IntPtr.Zero)
					prefix_jfieldId = JNIEnv.GetFieldID (class_ref, "prefix", "[S");
				return JavaArray<short>.FromJniHandle (JNIEnv.GetObjectField (Handle, prefix_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (prefix_jfieldId == IntPtr.Zero)
					prefix_jfieldId = JNIEnv.GetFieldID (class_ref, "prefix", "[S");
				IntPtr native_value = JavaArray<short>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, prefix_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr previousImage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='previousImage']"
		[Register ("previousImage")]
		protected global::Android.Graphics.Bitmap PreviousImage {
			get {
				if (previousImage_jfieldId == IntPtr.Zero)
					previousImage_jfieldId = JNIEnv.GetFieldID (class_ref, "previousImage", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, previousImage_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (previousImage_jfieldId == IntPtr.Zero)
					previousImage_jfieldId = JNIEnv.GetFieldID (class_ref, "previousImage", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, previousImage_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr rawData_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='rawData']"
		[Register ("rawData")]
		protected global::Java.Nio.ByteBuffer RawData {
			get {
				if (rawData_jfieldId == IntPtr.Zero)
					rawData_jfieldId = JNIEnv.GetFieldID (class_ref, "rawData", "Ljava/nio/ByteBuffer;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, rawData_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (rawData_jfieldId == IntPtr.Zero)
					rawData_jfieldId = JNIEnv.GetFieldID (class_ref, "rawData", "Ljava/nio/ByteBuffer;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, rawData_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr renderImage_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='renderImage']"
		[Register ("renderImage")]
		protected global::Android.Graphics.Bitmap RenderImage {
			get {
				if (renderImage_jfieldId == IntPtr.Zero)
					renderImage_jfieldId = JNIEnv.GetFieldID (class_ref, "renderImage", "Landroid/graphics/Bitmap;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, renderImage_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (renderImage_jfieldId == IntPtr.Zero)
					renderImage_jfieldId = JNIEnv.GetFieldID (class_ref, "renderImage", "Landroid/graphics/Bitmap;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, renderImage_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr status_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='status']"
		[Register ("status")]
		protected int Status {
			get {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "I");
				return JNIEnv.GetIntField (Handle, status_jfieldId);
			}
			set {
				if (status_jfieldId == IntPtr.Zero)
					status_jfieldId = JNIEnv.GetFieldID (class_ref, "status", "I");
				JNIEnv.SetField (Handle, status_jfieldId, value);
			}
		}

		static IntPtr suffix_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='suffix']"
		[Register ("suffix")]
		protected IList<byte> Suffix {
			get {
				if (suffix_jfieldId == IntPtr.Zero)
					suffix_jfieldId = JNIEnv.GetFieldID (class_ref, "suffix", "[B");
				return JavaArray<byte>.FromJniHandle (JNIEnv.GetObjectField (Handle, suffix_jfieldId), JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (suffix_jfieldId == IntPtr.Zero)
					suffix_jfieldId = JNIEnv.GetFieldID (class_ref, "suffix", "[B");
				IntPtr native_value = JavaArray<byte>.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, suffix_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}

		static IntPtr width_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/field[@name='width']"
		[Register ("width")]
		protected int Width {
			get {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				return JNIEnv.GetIntField (Handle, width_jfieldId);
			}
			set {
				if (width_jfieldId == IntPtr.Zero)
					width_jfieldId = JNIEnv.GetFieldID (class_ref, "width", "I");
				JNIEnv.SetField (Handle, width_jfieldId, value);
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder.GifFrame']"
		[global::Android.Runtime.Register ("com/felipecsl/gifimageview/library/GifDecoder$GifFrame", DoNotGenerateAcw=true)]
		public partial class GifFrame : global::Java.Lang.Object {


			static IntPtr bufferFrameStart_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder.GifFrame']/field[@name='bufferFrameStart']"
			[Register ("bufferFrameStart")]
			public int BufferFrameStart {
				get {
					if (bufferFrameStart_jfieldId == IntPtr.Zero)
						bufferFrameStart_jfieldId = JNIEnv.GetFieldID (class_ref, "bufferFrameStart", "I");
					return JNIEnv.GetIntField (Handle, bufferFrameStart_jfieldId);
				}
				set {
					if (bufferFrameStart_jfieldId == IntPtr.Zero)
						bufferFrameStart_jfieldId = JNIEnv.GetFieldID (class_ref, "bufferFrameStart", "I");
					JNIEnv.SetField (Handle, bufferFrameStart_jfieldId, value);
				}
			}

			static IntPtr delay_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder.GifFrame']/field[@name='delay']"
			[Register ("delay")]
			public int Delay {
				get {
					if (delay_jfieldId == IntPtr.Zero)
						delay_jfieldId = JNIEnv.GetFieldID (class_ref, "delay", "I");
					return JNIEnv.GetIntField (Handle, delay_jfieldId);
				}
				set {
					if (delay_jfieldId == IntPtr.Zero)
						delay_jfieldId = JNIEnv.GetFieldID (class_ref, "delay", "I");
					JNIEnv.SetField (Handle, delay_jfieldId, value);
				}
			}

			static IntPtr dispose_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder.GifFrame']/field[@name='dispose']"
			[Register ("dispose")]
			public int Dispose {
				get {
					if (dispose_jfieldId == IntPtr.Zero)
						dispose_jfieldId = JNIEnv.GetFieldID (class_ref, "dispose", "I");
					return JNIEnv.GetIntField (Handle, dispose_jfieldId);
				}
				set {
					if (dispose_jfieldId == IntPtr.Zero)
						dispose_jfieldId = JNIEnv.GetFieldID (class_ref, "dispose", "I");
					JNIEnv.SetField (Handle, dispose_jfieldId, value);
				}
			}

			static IntPtr ih_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder.GifFrame']/field[@name='ih']"
			[Register ("ih")]
			public int Ih {
				get {
					if (ih_jfieldId == IntPtr.Zero)
						ih_jfieldId = JNIEnv.GetFieldID (class_ref, "ih", "I");
					return JNIEnv.GetIntField (Handle, ih_jfieldId);
				}
				set {
					if (ih_jfieldId == IntPtr.Zero)
						ih_jfieldId = JNIEnv.GetFieldID (class_ref, "ih", "I");
					JNIEnv.SetField (Handle, ih_jfieldId, value);
				}
			}

			static IntPtr interlace_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder.GifFrame']/field[@name='interlace']"
			[Register ("interlace")]
			public bool Interlace {
				get {
					if (interlace_jfieldId == IntPtr.Zero)
						interlace_jfieldId = JNIEnv.GetFieldID (class_ref, "interlace", "Z");
					return JNIEnv.GetBooleanField (Handle, interlace_jfieldId);
				}
				set {
					if (interlace_jfieldId == IntPtr.Zero)
						interlace_jfieldId = JNIEnv.GetFieldID (class_ref, "interlace", "Z");
					JNIEnv.SetField (Handle, interlace_jfieldId, value);
				}
			}

			static IntPtr iw_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder.GifFrame']/field[@name='iw']"
			[Register ("iw")]
			public int Iw {
				get {
					if (iw_jfieldId == IntPtr.Zero)
						iw_jfieldId = JNIEnv.GetFieldID (class_ref, "iw", "I");
					return JNIEnv.GetIntField (Handle, iw_jfieldId);
				}
				set {
					if (iw_jfieldId == IntPtr.Zero)
						iw_jfieldId = JNIEnv.GetFieldID (class_ref, "iw", "I");
					JNIEnv.SetField (Handle, iw_jfieldId, value);
				}
			}

			static IntPtr ix_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder.GifFrame']/field[@name='ix']"
			[Register ("ix")]
			public int Ix {
				get {
					if (ix_jfieldId == IntPtr.Zero)
						ix_jfieldId = JNIEnv.GetFieldID (class_ref, "ix", "I");
					return JNIEnv.GetIntField (Handle, ix_jfieldId);
				}
				set {
					if (ix_jfieldId == IntPtr.Zero)
						ix_jfieldId = JNIEnv.GetFieldID (class_ref, "ix", "I");
					JNIEnv.SetField (Handle, ix_jfieldId, value);
				}
			}

			static IntPtr iy_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder.GifFrame']/field[@name='iy']"
			[Register ("iy")]
			public int Iy {
				get {
					if (iy_jfieldId == IntPtr.Zero)
						iy_jfieldId = JNIEnv.GetFieldID (class_ref, "iy", "I");
					return JNIEnv.GetIntField (Handle, iy_jfieldId);
				}
				set {
					if (iy_jfieldId == IntPtr.Zero)
						iy_jfieldId = JNIEnv.GetFieldID (class_ref, "iy", "I");
					JNIEnv.SetField (Handle, iy_jfieldId, value);
				}
			}

			static IntPtr lct_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder.GifFrame']/field[@name='lct']"
			[Register ("lct")]
			public IList<int> Lct {
				get {
					if (lct_jfieldId == IntPtr.Zero)
						lct_jfieldId = JNIEnv.GetFieldID (class_ref, "lct", "[I");
					return JavaArray<int>.FromJniHandle (JNIEnv.GetObjectField (Handle, lct_jfieldId), JniHandleOwnership.TransferLocalRef);
				}
				set {
					if (lct_jfieldId == IntPtr.Zero)
						lct_jfieldId = JNIEnv.GetFieldID (class_ref, "lct", "[I");
					IntPtr native_value = JavaArray<int>.ToLocalJniHandle (value);
					JNIEnv.SetField (Handle, lct_jfieldId, native_value);
					JNIEnv.DeleteLocalRef (native_value);
				}
			}

			static IntPtr transIndex_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder.GifFrame']/field[@name='transIndex']"
			[Register ("transIndex")]
			public int TransIndex {
				get {
					if (transIndex_jfieldId == IntPtr.Zero)
						transIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "transIndex", "I");
					return JNIEnv.GetIntField (Handle, transIndex_jfieldId);
				}
				set {
					if (transIndex_jfieldId == IntPtr.Zero)
						transIndex_jfieldId = JNIEnv.GetFieldID (class_ref, "transIndex", "I");
					JNIEnv.SetField (Handle, transIndex_jfieldId, value);
				}
			}

			static IntPtr transparency_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder.GifFrame']/field[@name='transparency']"
			[Register ("transparency")]
			public bool Transparency {
				get {
					if (transparency_jfieldId == IntPtr.Zero)
						transparency_jfieldId = JNIEnv.GetFieldID (class_ref, "transparency", "Z");
					return JNIEnv.GetBooleanField (Handle, transparency_jfieldId);
				}
				set {
					if (transparency_jfieldId == IntPtr.Zero)
						transparency_jfieldId = JNIEnv.GetFieldID (class_ref, "transparency", "Z");
					JNIEnv.SetField (Handle, transparency_jfieldId, value);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/felipecsl/gifimageview/library/GifDecoder$GifFrame", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (GifFrame); }
			}

			protected GifFrame (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/felipecsl/gifimageview/library/GifDecoder", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifDecoder); }
		}

		protected GifDecoder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/constructor[@name='GifDecoder' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public GifDecoder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GifDecoder)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "()V");
				return;
			}

			if (id_ctor == IntPtr.Zero)
				id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor);
		}

		static Delegate cb_getCurrentFrameIndex;
#pragma warning disable 0169
		static Delegate GetGetCurrentFrameIndexHandler ()
		{
			if (cb_getCurrentFrameIndex == null)
				cb_getCurrentFrameIndex = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCurrentFrameIndex);
			return cb_getCurrentFrameIndex;
		}

		static int n_GetCurrentFrameIndex (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CurrentFrameIndex;
		}
#pragma warning restore 0169

		static IntPtr id_getCurrentFrameIndex;
		public virtual int CurrentFrameIndex {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='getCurrentFrameIndex' and count(parameter)=0]"
			[Register ("getCurrentFrameIndex", "()I", "GetGetCurrentFrameIndexHandler")]
			get {
				if (id_getCurrentFrameIndex == IntPtr.Zero)
					id_getCurrentFrameIndex = JNIEnv.GetMethodID (class_ref, "getCurrentFrameIndex", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getCurrentFrameIndex);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCurrentFrameIndex", "()I"));
			}
		}

		static Delegate cb_getFrameCount;
#pragma warning disable 0169
		static Delegate GetGetFrameCountHandler ()
		{
			if (cb_getFrameCount == null)
				cb_getFrameCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetFrameCount);
			return cb_getFrameCount;
		}

		static int n_GetFrameCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.FrameCount;
		}
#pragma warning restore 0169

		static IntPtr id_getFrameCount;
		public virtual int FrameCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='getFrameCount' and count(parameter)=0]"
			[Register ("getFrameCount", "()I", "GetGetFrameCountHandler")]
			get {
				if (id_getFrameCount == IntPtr.Zero)
					id_getFrameCount = JNIEnv.GetMethodID (class_ref, "getFrameCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getFrameCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFrameCount", "()I"));
			}
		}

		static Delegate cb_getLoopCount;
#pragma warning disable 0169
		static Delegate GetGetLoopCountHandler ()
		{
			if (cb_getLoopCount == null)
				cb_getLoopCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetLoopCount);
			return cb_getLoopCount;
		}

		static int n_GetLoopCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.LoopCount;
		}
#pragma warning restore 0169

		static IntPtr id_getLoopCount;
		public virtual int LoopCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='getLoopCount' and count(parameter)=0]"
			[Register ("getLoopCount", "()I", "GetGetLoopCountHandler")]
			get {
				if (id_getLoopCount == IntPtr.Zero)
					id_getLoopCount = JNIEnv.GetMethodID (class_ref, "getLoopCount", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getLoopCount);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLoopCount", "()I"));
			}
		}

		static Delegate cb_getNextDelay;
#pragma warning disable 0169
		static Delegate GetGetNextDelayHandler ()
		{
			if (cb_getNextDelay == null)
				cb_getNextDelay = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetNextDelay);
			return cb_getNextDelay;
		}

		static int n_GetNextDelay (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.NextDelay;
		}
#pragma warning restore 0169

		static IntPtr id_getNextDelay;
		public virtual int NextDelay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='getNextDelay' and count(parameter)=0]"
			[Register ("getNextDelay", "()I", "GetGetNextDelayHandler")]
			get {
				if (id_getNextDelay == IntPtr.Zero)
					id_getNextDelay = JNIEnv.GetMethodID (class_ref, "getNextDelay", "()I");

				if (GetType () == ThresholdType)
					return JNIEnv.CallIntMethod  (Handle, id_getNextDelay);
				else
					return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextDelay", "()I"));
			}
		}

		static Delegate cb_getNextFrame;
#pragma warning disable 0169
		static Delegate GetGetNextFrameHandler ()
		{
			if (cb_getNextFrame == null)
				cb_getNextFrame = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetNextFrame);
			return cb_getNextFrame;
		}

		static IntPtr n_GetNextFrame (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.NextFrame);
		}
#pragma warning restore 0169

		static IntPtr id_getNextFrame;
		public virtual global::Android.Graphics.Bitmap NextFrame {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='getNextFrame' and count(parameter)=0]"
			[Register ("getNextFrame", "()Landroid/graphics/Bitmap;", "GetGetNextFrameHandler")]
			get {
				if (id_getNextFrame == IntPtr.Zero)
					id_getNextFrame = JNIEnv.GetMethodID (class_ref, "getNextFrame", "()Landroid/graphics/Bitmap;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getNextFrame), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getNextFrame", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_advance;
#pragma warning disable 0169
		static Delegate GetAdvanceHandler ()
		{
			if (cb_advance == null)
				cb_advance = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Advance);
			return cb_advance;
		}

		static void n_Advance (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Advance ();
		}
#pragma warning restore 0169

		static IntPtr id_advance;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='advance' and count(parameter)=0]"
		[Register ("advance", "()V", "GetAdvanceHandler")]
		public virtual void Advance ()
		{
			if (id_advance == IntPtr.Zero)
				id_advance = JNIEnv.GetMethodID (class_ref, "advance", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_advance);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "advance", "()V"));
		}

		static Delegate cb_err;
#pragma warning disable 0169
		static Delegate GetErrHandler ()
		{
			if (cb_err == null)
				cb_err = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_Err);
			return cb_err;
		}

		static bool n_Err (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Err ();
		}
#pragma warning restore 0169

		static IntPtr id_err;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='err' and count(parameter)=0]"
		[Register ("err", "()Z", "GetErrHandler")]
		protected virtual bool Err ()
		{
			if (id_err == IntPtr.Zero)
				id_err = JNIEnv.GetMethodID (class_ref, "err", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_err);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "err", "()Z"));
		}

		static Delegate cb_getDelay_I;
#pragma warning disable 0169
		static Delegate GetGetDelay_IHandler ()
		{
			if (cb_getDelay_I == null)
				cb_getDelay_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, int>) n_GetDelay_I);
			return cb_getDelay_I;
		}

		static int n_GetDelay_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.GetDelay (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getDelay_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='getDelay' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getDelay", "(I)I", "GetGetDelay_IHandler")]
		public virtual int GetDelay (int p0)
		{
			if (id_getDelay_I == IntPtr.Zero)
				id_getDelay_I = JNIEnv.GetMethodID (class_ref, "getDelay", "(I)I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_getDelay_I, new JValue (p0));
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDelay", "(I)I"), new JValue (p0));
		}

		static Delegate cb_init;
#pragma warning disable 0169
		static Delegate GetInitHandler ()
		{
			if (cb_init == null)
				cb_init = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Init);
			return cb_init;
		}

		static void n_Init (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Init ();
		}
#pragma warning restore 0169

		static IntPtr id_init;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='init' and count(parameter)=0]"
		[Register ("init", "()V", "GetInitHandler")]
		protected virtual void Init ()
		{
			if (id_init == IntPtr.Zero)
				id_init = JNIEnv.GetMethodID (class_ref, "init", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_init);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "init", "()V"));
		}

		static Delegate cb_read;
#pragma warning disable 0169
		static Delegate GetReadHandler ()
		{
			if (cb_read == null)
				cb_read = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_Read);
			return cb_read;
		}

		static int n_Read (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Read ();
		}
#pragma warning restore 0169

		static IntPtr id_read;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='read' and count(parameter)=0]"
		[Register ("read", "()I", "GetReadHandler")]
		protected virtual int Read ()
		{
			if (id_read == IntPtr.Zero)
				id_read = JNIEnv.GetMethodID (class_ref, "read", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_read);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "()I"));
		}

		static Delegate cb_read_arrayB;
#pragma warning disable 0169
		static Delegate GetRead_arrayBHandler ()
		{
			if (cb_read_arrayB == null)
				cb_read_arrayB = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int>) n_Read_arrayB);
			return cb_read_arrayB;
		}

		static int n_Read_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			int __ret = __this.Read (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='read' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("read", "([B)I", "GetRead_arrayBHandler")]
		public virtual int Read (byte[] p0)
		{
			if (id_read_arrayB == IntPtr.Zero)
				id_read_arrayB = JNIEnv.GetMethodID (class_ref, "read", "([B)I");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_read_arrayB, new JValue (native_p0));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "([B)I"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
			return __ret;
		}

		static Delegate cb_read_Ljava_io_InputStream_I;
#pragma warning disable 0169
		static Delegate GetRead_Ljava_io_InputStream_IHandler ()
		{
			if (cb_read_Ljava_io_InputStream_I == null)
				cb_read_Ljava_io_InputStream_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, int, int>) n_Read_Ljava_io_InputStream_I);
			return cb_read_Ljava_io_InputStream_I;
		}

		static int n_Read_Ljava_io_InputStream_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			System.IO.Stream p0 = global::Android.Runtime.InputStreamInvoker.FromJniHandle (native_p0, JniHandleOwnership.DoNotTransfer);
			int __ret = __this.Read (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_read_Ljava_io_InputStream_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='read' and count(parameter)=2 and parameter[1][@type='java.io.InputStream'] and parameter[2][@type='int']]"
		[Register ("read", "(Ljava/io/InputStream;I)I", "GetRead_Ljava_io_InputStream_IHandler")]
		public virtual int Read (global::System.IO.Stream p0, int p1)
		{
			if (id_read_Ljava_io_InputStream_I == IntPtr.Zero)
				id_read_Ljava_io_InputStream_I = JNIEnv.GetMethodID (class_ref, "read", "(Ljava/io/InputStream;I)I");
			IntPtr native_p0 = global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (p0);

			int __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallIntMethod  (Handle, id_read_Ljava_io_InputStream_I, new JValue (native_p0), new JValue (p1));
			else
				__ret = JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "read", "(Ljava/io/InputStream;I)I"), new JValue (native_p0), new JValue (p1));
			JNIEnv.DeleteLocalRef (native_p0);
			return __ret;
		}

		static Delegate cb_readBitmap;
#pragma warning disable 0169
		static Delegate GetReadBitmapHandler ()
		{
			if (cb_readBitmap == null)
				cb_readBitmap = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadBitmap);
			return cb_readBitmap;
		}

		static void n_ReadBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadBitmap ();
		}
#pragma warning restore 0169

		static IntPtr id_readBitmap;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='readBitmap' and count(parameter)=0]"
		[Register ("readBitmap", "()V", "GetReadBitmapHandler")]
		protected virtual void ReadBitmap ()
		{
			if (id_readBitmap == IntPtr.Zero)
				id_readBitmap = JNIEnv.GetMethodID (class_ref, "readBitmap", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_readBitmap);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readBitmap", "()V"));
		}

		static Delegate cb_readBlock;
#pragma warning disable 0169
		static Delegate GetReadBlockHandler ()
		{
			if (cb_readBlock == null)
				cb_readBlock = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ReadBlock);
			return cb_readBlock;
		}

		static int n_ReadBlock (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadBlock ();
		}
#pragma warning restore 0169

		static IntPtr id_readBlock;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='readBlock' and count(parameter)=0]"
		[Register ("readBlock", "()I", "GetReadBlockHandler")]
		protected virtual int ReadBlock ()
		{
			if (id_readBlock == IntPtr.Zero)
				id_readBlock = JNIEnv.GetMethodID (class_ref, "readBlock", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_readBlock);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readBlock", "()I"));
		}

		static Delegate cb_readColorTable_I;
#pragma warning disable 0169
		static Delegate GetReadColorTable_IHandler ()
		{
			if (cb_readColorTable_I == null)
				cb_readColorTable_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_ReadColorTable_I);
			return cb_readColorTable_I;
		}

		static IntPtr n_ReadColorTable_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.ReadColorTable (p0));
		}
#pragma warning restore 0169

		static IntPtr id_readColorTable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='readColorTable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("readColorTable", "(I)[I", "GetReadColorTable_IHandler")]
		protected virtual int[] ReadColorTable (int p0)
		{
			if (id_readColorTable_I == IntPtr.Zero)
				id_readColorTable_I = JNIEnv.GetMethodID (class_ref, "readColorTable", "(I)[I");

			if (GetType () == ThresholdType)
				return (int[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod  (Handle, id_readColorTable_I, new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (int));
			else
				return (int[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readColorTable", "(I)[I"), new JValue (p0)), JniHandleOwnership.TransferLocalRef, typeof (int));
		}

		static Delegate cb_readContents;
#pragma warning disable 0169
		static Delegate GetReadContentsHandler ()
		{
			if (cb_readContents == null)
				cb_readContents = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadContents);
			return cb_readContents;
		}

		static void n_ReadContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadContents ();
		}
#pragma warning restore 0169

		static IntPtr id_readContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='readContents' and count(parameter)=0]"
		[Register ("readContents", "()V", "GetReadContentsHandler")]
		protected virtual void ReadContents ()
		{
			if (id_readContents == IntPtr.Zero)
				id_readContents = JNIEnv.GetMethodID (class_ref, "readContents", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_readContents);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readContents", "()V"));
		}

		static Delegate cb_readGraphicControlExt;
#pragma warning disable 0169
		static Delegate GetReadGraphicControlExtHandler ()
		{
			if (cb_readGraphicControlExt == null)
				cb_readGraphicControlExt = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadGraphicControlExt);
			return cb_readGraphicControlExt;
		}

		static void n_ReadGraphicControlExt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadGraphicControlExt ();
		}
#pragma warning restore 0169

		static IntPtr id_readGraphicControlExt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='readGraphicControlExt' and count(parameter)=0]"
		[Register ("readGraphicControlExt", "()V", "GetReadGraphicControlExtHandler")]
		protected virtual void ReadGraphicControlExt ()
		{
			if (id_readGraphicControlExt == IntPtr.Zero)
				id_readGraphicControlExt = JNIEnv.GetMethodID (class_ref, "readGraphicControlExt", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_readGraphicControlExt);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readGraphicControlExt", "()V"));
		}

		static Delegate cb_readHeader;
#pragma warning disable 0169
		static Delegate GetReadHeaderHandler ()
		{
			if (cb_readHeader == null)
				cb_readHeader = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadHeader);
			return cb_readHeader;
		}

		static void n_ReadHeader (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadHeader ();
		}
#pragma warning restore 0169

		static IntPtr id_readHeader;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='readHeader' and count(parameter)=0]"
		[Register ("readHeader", "()V", "GetReadHeaderHandler")]
		protected virtual void ReadHeader ()
		{
			if (id_readHeader == IntPtr.Zero)
				id_readHeader = JNIEnv.GetMethodID (class_ref, "readHeader", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_readHeader);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readHeader", "()V"));
		}

		static Delegate cb_readLSD;
#pragma warning disable 0169
		static Delegate GetReadLSDHandler ()
		{
			if (cb_readLSD == null)
				cb_readLSD = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadLSD);
			return cb_readLSD;
		}

		static void n_ReadLSD (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadLSD ();
		}
#pragma warning restore 0169

		static IntPtr id_readLSD;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='readLSD' and count(parameter)=0]"
		[Register ("readLSD", "()V", "GetReadLSDHandler")]
		protected virtual void ReadLSD ()
		{
			if (id_readLSD == IntPtr.Zero)
				id_readLSD = JNIEnv.GetMethodID (class_ref, "readLSD", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_readLSD);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readLSD", "()V"));
		}

		static Delegate cb_readNetscapeExt;
#pragma warning disable 0169
		static Delegate GetReadNetscapeExtHandler ()
		{
			if (cb_readNetscapeExt == null)
				cb_readNetscapeExt = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ReadNetscapeExt);
			return cb_readNetscapeExt;
		}

		static void n_ReadNetscapeExt (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ReadNetscapeExt ();
		}
#pragma warning restore 0169

		static IntPtr id_readNetscapeExt;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='readNetscapeExt' and count(parameter)=0]"
		[Register ("readNetscapeExt", "()V", "GetReadNetscapeExtHandler")]
		protected virtual void ReadNetscapeExt ()
		{
			if (id_readNetscapeExt == IntPtr.Zero)
				id_readNetscapeExt = JNIEnv.GetMethodID (class_ref, "readNetscapeExt", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_readNetscapeExt);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readNetscapeExt", "()V"));
		}

		static Delegate cb_readShort;
#pragma warning disable 0169
		static Delegate GetReadShortHandler ()
		{
			if (cb_readShort == null)
				cb_readShort = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_ReadShort);
			return cb_readShort;
		}

		static int n_ReadShort (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.ReadShort ();
		}
#pragma warning restore 0169

		static IntPtr id_readShort;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='readShort' and count(parameter)=0]"
		[Register ("readShort", "()I", "GetReadShortHandler")]
		protected virtual int ReadShort ()
		{
			if (id_readShort == IntPtr.Zero)
				id_readShort = JNIEnv.GetMethodID (class_ref, "readShort", "()I");

			if (GetType () == ThresholdType)
				return JNIEnv.CallIntMethod  (Handle, id_readShort);
			else
				return JNIEnv.CallNonvirtualIntMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readShort", "()I"));
		}

		static Delegate cb_setPixels_I;
#pragma warning disable 0169
		static Delegate GetSetPixels_IHandler ()
		{
			if (cb_setPixels_I == null)
				cb_setPixels_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetPixels_I);
			return cb_setPixels_I;
		}

		static void n_SetPixels_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPixels (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPixels_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='setPixels' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setPixels", "(I)V", "GetSetPixels_IHandler")]
		protected virtual void SetPixels (int p0)
		{
			if (id_setPixels_I == IntPtr.Zero)
				id_setPixels_I = JNIEnv.GetMethodID (class_ref, "setPixels", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPixels_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPixels", "(I)V"), new JValue (p0));
		}

		static Delegate cb_skip;
#pragma warning disable 0169
		static Delegate GetSkipHandler ()
		{
			if (cb_skip == null)
				cb_skip = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Skip);
			return cb_skip;
		}

		static void n_Skip (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifDecoder __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifDecoder> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Skip ();
		}
#pragma warning restore 0169

		static IntPtr id_skip;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifDecoder']/method[@name='skip' and count(parameter)=0]"
		[Register ("skip", "()V", "GetSkipHandler")]
		protected virtual void Skip ()
		{
			if (id_skip == IntPtr.Zero)
				id_skip = JNIEnv.GetMethodID (class_ref, "skip", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_skip);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "skip", "()V"));
		}

	}
}
