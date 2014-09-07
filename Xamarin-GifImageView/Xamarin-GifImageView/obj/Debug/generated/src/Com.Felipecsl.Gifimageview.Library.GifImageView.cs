using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Felipecsl.Gifimageview.Library {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifImageView']"
	[global::Android.Runtime.Register ("com/felipecsl/gifimageview/library/GifImageView", DoNotGenerateAcw=true)]
	public partial class GifImageView : global::Android.Widget.ImageView, global::Java.Lang.IRunnable {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/felipecsl/gifimageview/library/GifImageView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (GifImageView); }
		}

		protected GifImageView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifImageView']/constructor[@name='GifImageView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public GifImageView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GifImageView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifImageView']/constructor[@name='GifImageView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public GifImageView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (GifImageView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

		static Delegate cb_isAnimating;
#pragma warning disable 0169
		static Delegate GetIsAnimatingHandler ()
		{
			if (cb_isAnimating == null)
				cb_isAnimating = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAnimating);
			return cb_isAnimating;
		}

		static bool n_IsAnimating (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifImageView __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAnimating;
		}
#pragma warning restore 0169

		static IntPtr id_isAnimating;
		public virtual bool IsAnimating {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifImageView']/method[@name='isAnimating' and count(parameter)=0]"
			[Register ("isAnimating", "()Z", "GetIsAnimatingHandler")]
			get {
				if (id_isAnimating == IntPtr.Zero)
					id_isAnimating = JNIEnv.GetMethodID (class_ref, "isAnimating", "()Z");

				if (GetType () == ThresholdType)
					return JNIEnv.CallBooleanMethod  (Handle, id_isAnimating);
				else
					return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAnimating", "()Z"));
			}
		}

		static Delegate cb_clear;
#pragma warning disable 0169
		static Delegate GetClearHandler ()
		{
			if (cb_clear == null)
				cb_clear = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Clear);
			return cb_clear;
		}

		static void n_Clear (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifImageView __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Clear ();
		}
#pragma warning restore 0169

		static IntPtr id_clear;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifImageView']/method[@name='clear' and count(parameter)=0]"
		[Register ("clear", "()V", "GetClearHandler")]
		public virtual void Clear ()
		{
			if (id_clear == IntPtr.Zero)
				id_clear = JNIEnv.GetMethodID (class_ref, "clear", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_clear);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clear", "()V"));
		}

		static Delegate cb_run;
#pragma warning disable 0169
		static Delegate GetRunHandler ()
		{
			if (cb_run == null)
				cb_run = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Run);
			return cb_run;
		}

		static void n_Run (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifImageView __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Run ();
		}
#pragma warning restore 0169

		static IntPtr id_run;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifImageView']/method[@name='run' and count(parameter)=0]"
		[Register ("run", "()V", "GetRunHandler")]
		public virtual void Run ()
		{
			if (id_run == IntPtr.Zero)
				id_run = JNIEnv.GetMethodID (class_ref, "run", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_run);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "run", "()V"));
		}

		static Delegate cb_setBytes_arrayB;
#pragma warning disable 0169
		static Delegate GetSetBytes_arrayBHandler ()
		{
			if (cb_setBytes_arrayB == null)
				cb_setBytes_arrayB = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBytes_arrayB);
			return cb_setBytes_arrayB;
		}

		static void n_SetBytes_arrayB (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifImageView __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			byte[] p0 = (byte[]) JNIEnv.GetArray (native_p0, JniHandleOwnership.DoNotTransfer, typeof (byte));
			__this.SetBytes (p0);
			if (p0 != null)
				JNIEnv.CopyArray (p0, native_p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBytes_arrayB;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifImageView']/method[@name='setBytes' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("setBytes", "([B)V", "GetSetBytes_arrayBHandler")]
		public virtual void SetBytes (byte[] p0)
		{
			if (id_setBytes_arrayB == IntPtr.Zero)
				id_setBytes_arrayB = JNIEnv.GetMethodID (class_ref, "setBytes", "([B)V");
			IntPtr native_p0 = JNIEnv.NewArray (p0);

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setBytes_arrayB, new JValue (native_p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBytes", "([B)V"), new JValue (native_p0));
			if (p0 != null) {
				JNIEnv.CopyArray (native_p0, p0);
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_startAnimation;
#pragma warning disable 0169
		static Delegate GetStartAnimationHandler ()
		{
			if (cb_startAnimation == null)
				cb_startAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StartAnimation);
			return cb_startAnimation;
		}

		static void n_StartAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifImageView __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StartAnimation ();
		}
#pragma warning restore 0169

		static IntPtr id_startAnimation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifImageView']/method[@name='startAnimation' and count(parameter)=0]"
		[Register ("startAnimation", "()V", "GetStartAnimationHandler")]
		public virtual void StartAnimation ()
		{
			if (id_startAnimation == IntPtr.Zero)
				id_startAnimation = JNIEnv.GetMethodID (class_ref, "startAnimation", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_startAnimation);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "startAnimation", "()V"));
		}

		static Delegate cb_stopAnimation;
#pragma warning disable 0169
		static Delegate GetStopAnimationHandler ()
		{
			if (cb_stopAnimation == null)
				cb_stopAnimation = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_StopAnimation);
			return cb_stopAnimation;
		}

		static void n_StopAnimation (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Felipecsl.Gifimageview.Library.GifImageView __this = global::Java.Lang.Object.GetObject<global::Com.Felipecsl.Gifimageview.Library.GifImageView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.StopAnimation ();
		}
#pragma warning restore 0169

		static IntPtr id_stopAnimation;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.felipecsl.gifimageview.library']/class[@name='GifImageView']/method[@name='stopAnimation' and count(parameter)=0]"
		[Register ("stopAnimation", "()V", "GetStopAnimationHandler")]
		public virtual void StopAnimation ()
		{
			if (id_stopAnimation == IntPtr.Zero)
				id_stopAnimation = JNIEnv.GetMethodID (class_ref, "stopAnimation", "()V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_stopAnimation);
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "stopAnimation", "()V"));
		}

	}
}
