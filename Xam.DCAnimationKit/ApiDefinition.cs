using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;


namespace Xam.DCAnimationKit
{
	

	// typedef void (^DCAnimationFinished)();
	delegate void DCAnimationFinished();

	// @interface DCAnimationKit (UIView)
	[Category]
	[BaseType(typeof(UIView))]
	interface UIView_DCAnimationKit
	{
		// -(void)setX:(CGFloat)x duration:(NSTimeInterval)time finished:(DCAnimationFinished)finished;
		[Export("setX:duration:finished:")]
		void SetX(nfloat x, double time, DCAnimationFinished finished);

		// -(void)setX:(CGFloat)x finished:(DCAnimationFinished)finished;
		[Export("setX:finished:")]
		void SetX(nfloat x, DCAnimationFinished finished);

		// -(void)moveX:(CGFloat)x duration:(NSTimeInterval)time finished:(DCAnimationFinished)finished;
		[Export("moveX:duration:finished:")]
		void MoveX(nfloat x, double time, DCAnimationFinished finished);

		// -(void)moveX:(CGFloat)x finished:(DCAnimationFinished)finished;
		[Export("moveX:finished:")]
		void MoveX(nfloat x, DCAnimationFinished finished);

		// -(void)setY:(CGFloat)y duration:(NSTimeInterval)time finished:(DCAnimationFinished)finished;
		[Export("setY:duration:finished:")]
		void SetY(nfloat y, double time, DCAnimationFinished finished);

		// -(void)setY:(CGFloat)y finished:(DCAnimationFinished)finished;
		[Export("setY:finished:")]
		void SetY(nfloat y, DCAnimationFinished finished);

		// -(void)moveY:(CGFloat)y duration:(NSTimeInterval)time finished:(DCAnimationFinished)finished;
		[Export("moveY:duration:finished:")]
		void MoveY(nfloat y, double time, DCAnimationFinished finished);

		// -(void)moveY:(CGFloat)y finished:(DCAnimationFinished)finished;
		[Export("moveY:finished:")]
		void MoveY(nfloat y, DCAnimationFinished finished);

		// -(void)setPoint:(CGPoint)point duration:(NSTimeInterval)time finished:(DCAnimationFinished)finished;
		[Export("setPoint:duration:finished:")]
		void SetPoint(CGPoint point, double time, DCAnimationFinished finished);

		// -(void)setPoint:(CGPoint)point finished:(DCAnimationFinished)finished;
		[Export("setPoint:finished:")]
		void SetPoint(CGPoint point, DCAnimationFinished finished);

		// -(void)movePoint:(CGPoint)point duration:(NSTimeInterval)time finished:(DCAnimationFinished)finished;
		[Export("movePoint:duration:finished:")]
		void MovePoint(CGPoint point, double time, DCAnimationFinished finished);

		// -(void)movePoint:(CGPoint)point finished:(DCAnimationFinished)finished;
		[Export("movePoint:finished:")]
		void MovePoint(CGPoint point, DCAnimationFinished finished);

		// -(void)setRotation:(CGFloat)r duration:(NSTimeInterval)time finished:(DCAnimationFinished)finished;
		[Export("setRotation:duration:finished:")]
		void SetRotation(nfloat r, double time, DCAnimationFinished finished);

		// -(void)setRotation:(CGFloat)r finished:(DCAnimationFinished)finished;
		[Export("setRotation:finished:")]
		void SetRotation(nfloat r, DCAnimationFinished finished);

		// -(void)moveRotation:(CGFloat)r duration:(NSTimeInterval)time finished:(DCAnimationFinished)finished;
		[Export("moveRotation:duration:finished:")]
		void MoveRotation(nfloat r, double time, DCAnimationFinished finished);

		// -(void)moveRotation:(CGFloat)r finished:(DCAnimationFinished)finished;
		[Export("moveRotation:finished:")]
		void MoveRotation(nfloat r, DCAnimationFinished finished);

		// -(void)bounce:(DCAnimationFinished)finished;
		[Export("bounce:")]
		void Bounce(DCAnimationFinished finished);

		// -(void)bounce:(CGFloat)height finished:(DCAnimationFinished)finished;
		[Export("bounce:finished:")]
		void Bounce(nfloat height, DCAnimationFinished finished);

		// -(void)pulse:(DCAnimationFinished)finished;
		[Export("pulse:")]
		void Pulse(DCAnimationFinished finished);

		// -(void)shake:(DCAnimationFinished)finished;
		[Export("shake:")]
		void Shake(DCAnimationFinished finished);

		// -(void)swing:(DCAnimationFinished)finished;
		[Export("swing:")]
		void Swing(DCAnimationFinished finished);

		// -(void)tada:(DCAnimationFinished)finished;
		[Export("tada:")]
		void Tada(DCAnimationFinished finished);

		// -(void)snapIntoView:(UIView *)view direction:(DCAnimationDirection)direction;
		[Export("snapIntoView:direction:")]
		void SnapIntoView(UIView view, DCAnimationDirection direction);

		// -(void)bounceIntoView:(UIView *)view direction:(DCAnimationDirection)direction;
		[Export("bounceIntoView:direction:")]
		void BounceIntoView(UIView view, DCAnimationDirection direction);

		// -(void)expandIntoView:(UIView *)view finished:(DCAnimationFinished)finished;
		[Export("expandIntoView:finished:")]
		void ExpandIntoView(UIView view, DCAnimationFinished finished);

		// -(void)compressIntoView:(DCAnimationFinished)finished;
		[Export("compressIntoView:")]
		void CompressIntoView(DCAnimationFinished finished);

		// -(void)hinge:(DCAnimationFinished)finished;
		[Export("hinge:")]
		void Hinge(DCAnimationFinished finished);

		// -(void)drop:(DCAnimationFinished)finished;
		[Export("drop:")]
		void Drop(DCAnimationFinished finished);

		// -(void)removeCurrentAnimations;
		[Export("removeCurrentAnimations")]
		void RemoveCurrentAnimations();
	}

	[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double DCAnimationKitVersionNumber;
		[Field("DCAnimationKitVersionNumber", "__Internal")]
		double DCAnimationKitVersionNumber { get; }

		// extern const unsigned char [] DCAnimationKitVersionString;
		[Field("DCAnimationKitVersionString", "__Internal")]
		IntPtr DCAnimationKitVersionString { get; }
	}

}