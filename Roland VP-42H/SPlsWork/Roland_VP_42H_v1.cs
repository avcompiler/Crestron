using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_ROLAND_VP_42H_V1
{
    public class UserModuleClass_ROLAND_VP_42H_V1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput SCENE_1;
        Crestron.Logos.SplusObjects.DigitalInput SCENE_2;
        Crestron.Logos.SplusObjects.DigitalInput SCENE_3;
        Crestron.Logos.SplusObjects.DigitalInput SCENE_4;
        Crestron.Logos.SplusObjects.DigitalInput SCENE_5;
        Crestron.Logos.SplusObjects.DigitalInput SCENE_6;
        Crestron.Logos.SplusObjects.DigitalInput SCENE_7;
        Crestron.Logos.SplusObjects.DigitalInput SCENE_8;
        Crestron.Logos.SplusObjects.DigitalInput SCENE_9;
        Crestron.Logos.SplusObjects.DigitalInput SCENE_10;
        Crestron.Logos.SplusObjects.DigitalInput SHOW_LAYER_1;
        Crestron.Logos.SplusObjects.DigitalInput SHOW_LAYER_2;
        Crestron.Logos.SplusObjects.DigitalInput SHOW_LAYER_3;
        Crestron.Logos.SplusObjects.DigitalInput SHOW_LAYER_4;
        Crestron.Logos.SplusObjects.DigitalInput HIDE_LAYER_1;
        Crestron.Logos.SplusObjects.DigitalInput HIDE_LAYER_2;
        Crestron.Logos.SplusObjects.DigitalInput HIDE_LAYER_3;
        Crestron.Logos.SplusObjects.DigitalInput HIDE_LAYER_4;
        Crestron.Logos.SplusObjects.DigitalInput IN_1_LAYER_1;
        Crestron.Logos.SplusObjects.DigitalInput IN_2_LAYER_1;
        Crestron.Logos.SplusObjects.DigitalInput IN_3_LAYER_1;
        Crestron.Logos.SplusObjects.DigitalInput IN_4_LAYER_1;
        Crestron.Logos.SplusObjects.DigitalInput BLANK_LAYER_1;
        Crestron.Logos.SplusObjects.DigitalInput IN_1_LAYER_2;
        Crestron.Logos.SplusObjects.DigitalInput IN_2_LAYER_2;
        Crestron.Logos.SplusObjects.DigitalInput IN_3_LAYER_2;
        Crestron.Logos.SplusObjects.DigitalInput IN_4_LAYER_2;
        Crestron.Logos.SplusObjects.DigitalInput BLANK_LAYER_2;
        Crestron.Logos.SplusObjects.DigitalInput IN_1_LAYER_3;
        Crestron.Logos.SplusObjects.DigitalInput IN_2_LAYER_3;
        Crestron.Logos.SplusObjects.DigitalInput IN_3_LAYER_3;
        Crestron.Logos.SplusObjects.DigitalInput IN_4_LAYER_3;
        Crestron.Logos.SplusObjects.DigitalInput BLANK_LAYER_3;
        Crestron.Logos.SplusObjects.DigitalInput IN_1_LAYER_4;
        Crestron.Logos.SplusObjects.DigitalInput IN_2_LAYER_4;
        Crestron.Logos.SplusObjects.DigitalInput IN_3_LAYER_4;
        Crestron.Logos.SplusObjects.DigitalInput IN_4_LAYER_4;
        Crestron.Logos.SplusObjects.DigitalInput BLANK_LAYER_4;
        Crestron.Logos.SplusObjects.AnalogInput SCENE_TRANSITION_TIME;
        Crestron.Logos.SplusObjects.StringInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput SCENE_1_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SCENE_2_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SCENE_3_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SCENE_4_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SCENE_5_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SCENE_6_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SCENE_7_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SCENE_8_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SCENE_9_FB;
        Crestron.Logos.SplusObjects.DigitalOutput SCENE_10_FB;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        ushort END = 0;
        object SCENE_1_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 71;
                MakeString ( TX__DOLLAR__ , "set,11,11,0,0") ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SCENE_2_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 75;
            MakeString ( TX__DOLLAR__ , "set,11,11,0,1") ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object SCENE_3_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 80;
        MakeString ( TX__DOLLAR__ , "set,11,11,0,2") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCENE_4_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 85;
        MakeString ( TX__DOLLAR__ , "set,11,11,0,3") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCENE_5_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 90;
        MakeString ( TX__DOLLAR__ , "set,11,11,0,4") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCENE_6_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 95;
        MakeString ( TX__DOLLAR__ , "set,11,11,0,5") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCENE_7_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 100;
        MakeString ( TX__DOLLAR__ , "set,11,11,0,6") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCENE_8_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 105;
        MakeString ( TX__DOLLAR__ , "set,11,11,0,7") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCENE_9_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 110;
        MakeString ( TX__DOLLAR__ , "set,11,11,0,8") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCENE_10_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 115;
        MakeString ( TX__DOLLAR__ , "set,11,11,0,9") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SHOW_LAYER_1_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 120;
        MakeString ( TX__DOLLAR__ , "set,15,41,0,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SHOW_LAYER_2_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 125;
        MakeString ( TX__DOLLAR__ , "set,15,41,1,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SHOW_LAYER_3_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 130;
        MakeString ( TX__DOLLAR__ , "set,15,41,2,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SHOW_LAYER_4_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 135;
        MakeString ( TX__DOLLAR__ , "set,15,41,3,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HIDE_LAYER_1_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 140;
        MakeString ( TX__DOLLAR__ , "set,15,41,0,0") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HIDE_LAYER_2_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 145;
        MakeString ( TX__DOLLAR__ , "set,15,41,1,0") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HIDE_LAYER_3_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 150;
        MakeString ( TX__DOLLAR__ , "set,15,41,2,0") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HIDE_LAYER_4_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 155;
        MakeString ( TX__DOLLAR__ , "set,15,41,3,0") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_1_LAYER_1_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 160;
        MakeString ( TX__DOLLAR__ , "set,15,42,0,0") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_2_LAYER_1_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 165;
        MakeString ( TX__DOLLAR__ , "set,15,42,0,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_3_LAYER_1_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 170;
        MakeString ( TX__DOLLAR__ , "set,15,42,0,2") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_4_LAYER_1_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 175;
        MakeString ( TX__DOLLAR__ , "set,15,42,0,3") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BLANK_LAYER_1_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 180;
        MakeString ( TX__DOLLAR__ , "set,15,42,0,4") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_1_LAYER_2_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 185;
        MakeString ( TX__DOLLAR__ , "set,15,42,1,0") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_2_LAYER_2_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 190;
        MakeString ( TX__DOLLAR__ , "set,15,42,1,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_3_LAYER_2_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 195;
        MakeString ( TX__DOLLAR__ , "set,15,42,1,2") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_4_LAYER_2_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 200;
        MakeString ( TX__DOLLAR__ , "set,15,42,1,3") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BLANK_LAYER_2_OnPush_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 205;
        MakeString ( TX__DOLLAR__ , "set,15,42,1,4") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_1_LAYER_3_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 210;
        MakeString ( TX__DOLLAR__ , "set,15,42,2,0") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_2_LAYER_3_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 215;
        MakeString ( TX__DOLLAR__ , "set,15,42,2,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_3_LAYER_3_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 220;
        MakeString ( TX__DOLLAR__ , "set,15,42,2,2") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_4_LAYER_3_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 225;
        MakeString ( TX__DOLLAR__ , "set,15,42,2,3") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BLANK_LAYER_3_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 230;
        MakeString ( TX__DOLLAR__ , "set,15,42,2,4") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_1_LAYER_4_OnPush_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 235;
        MakeString ( TX__DOLLAR__ , "set,15,42,3,0") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_2_LAYER_4_OnPush_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 240;
        MakeString ( TX__DOLLAR__ , "set,15,42,3,1") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_3_LAYER_4_OnPush_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 245;
        MakeString ( TX__DOLLAR__ , "set,15,42,3,2") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object IN_4_LAYER_4_OnPush_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 250;
        MakeString ( TX__DOLLAR__ , "set,15,42,3,3") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BLANK_LAYER_4_OnPush_37 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 255;
        MakeString ( TX__DOLLAR__ , "set,15,42,3,4") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SCENE_TRANSITION_TIME_OnChange_38 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString X;
        X  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
        
        ushort A = 0;
        
        
        __context__.SourceCodeLine = 263;
        A = (ushort) ( (SCENE_TRANSITION_TIME  .UshortValue / 4000) ) ; 
        __context__.SourceCodeLine = 264;
        X  .UpdateValue ( Functions.ItoA (  (int) ( A ) )  ) ; 
        __context__.SourceCodeLine = 265;
        MakeString ( TX__DOLLAR__ , "set,10,19,0,{0}", X ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object RX__DOLLAR___OnChange_39 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString X;
        X  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
        
        
        __context__.SourceCodeLine = 271;
        X  .UpdateValue ( Functions.Gather ( "\u000A" , RX__DOLLAR__ )  ) ; 
        __context__.SourceCodeLine = 272;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Length( X ) ) && Functions.TestForTrue ( Functions.Find( "ack,11,11,0,0" , X ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 274;
            SCENE_1_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 275;
            SCENE_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 276;
            SCENE_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 277;
            SCENE_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 278;
            SCENE_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 279;
            SCENE_6_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 280;
            SCENE_7_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 281;
            SCENE_8_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 282;
            SCENE_9_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 283;
            SCENE_10_FB  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 285;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Length( X ) ) && Functions.TestForTrue ( Functions.Find( "ack,11,11,0,1" , X ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 287;
            SCENE_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 288;
            SCENE_2_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 289;
            SCENE_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 290;
            SCENE_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 291;
            SCENE_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 292;
            SCENE_6_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 293;
            SCENE_7_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 294;
            SCENE_8_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 295;
            SCENE_9_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 296;
            SCENE_10_FB  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 298;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Length( X ) ) && Functions.TestForTrue ( Functions.Find( "ack,11,11,0,2" , X ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 300;
            SCENE_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 301;
            SCENE_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 302;
            SCENE_3_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 303;
            SCENE_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 304;
            SCENE_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 305;
            SCENE_6_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 306;
            SCENE_7_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 307;
            SCENE_8_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 308;
            SCENE_9_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 309;
            SCENE_10_FB  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 311;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Length( X ) ) && Functions.TestForTrue ( Functions.Find( "ack,11,11,0,3" , X ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 313;
            SCENE_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 314;
            SCENE_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 315;
            SCENE_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 316;
            SCENE_4_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 317;
            SCENE_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 318;
            SCENE_6_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 319;
            SCENE_7_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 320;
            SCENE_8_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 321;
            SCENE_9_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 322;
            SCENE_10_FB  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 324;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Length( X ) ) && Functions.TestForTrue ( Functions.Find( "ack,11,11,0,4" , X ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 326;
            SCENE_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 327;
            SCENE_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 328;
            SCENE_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 329;
            SCENE_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 330;
            SCENE_5_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 331;
            SCENE_6_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 332;
            SCENE_7_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 333;
            SCENE_8_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 334;
            SCENE_9_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 335;
            SCENE_10_FB  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 337;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Length( X ) ) && Functions.TestForTrue ( Functions.Find( "ack,11,11,0,5" , X ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 339;
            SCENE_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 340;
            SCENE_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 341;
            SCENE_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 342;
            SCENE_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 343;
            SCENE_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 344;
            SCENE_6_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 345;
            SCENE_7_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 346;
            SCENE_8_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 347;
            SCENE_9_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 348;
            SCENE_10_FB  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 350;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Length( X ) ) && Functions.TestForTrue ( Functions.Find( "ack,11,11,0,6" , X ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 352;
            SCENE_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 353;
            SCENE_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 354;
            SCENE_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 355;
            SCENE_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 356;
            SCENE_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 357;
            SCENE_6_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 358;
            SCENE_7_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 359;
            SCENE_8_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 360;
            SCENE_9_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 361;
            SCENE_10_FB  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 363;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Length( X ) ) && Functions.TestForTrue ( Functions.Find( "ack,11,11,0,7" , X ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 365;
            SCENE_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 366;
            SCENE_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 367;
            SCENE_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 368;
            SCENE_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 369;
            SCENE_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 370;
            SCENE_6_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 371;
            SCENE_7_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 372;
            SCENE_8_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 373;
            SCENE_9_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 374;
            SCENE_10_FB  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 376;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Length( X ) ) && Functions.TestForTrue ( Functions.Find( "ack,11,11,0,8" , X ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 378;
            SCENE_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 379;
            SCENE_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 380;
            SCENE_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 381;
            SCENE_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 382;
            SCENE_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 383;
            SCENE_6_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 384;
            SCENE_7_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 385;
            SCENE_8_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 386;
            SCENE_9_FB  .Value = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 387;
            SCENE_10_FB  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 389;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Length( X ) ) && Functions.TestForTrue ( Functions.Find( "ack,11,11,0,9" , X ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 391;
            SCENE_1_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 392;
            SCENE_2_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 393;
            SCENE_3_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 394;
            SCENE_4_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 395;
            SCENE_5_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 396;
            SCENE_6_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 397;
            SCENE_7_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 398;
            SCENE_8_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 399;
            SCENE_9_FB  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 400;
            SCENE_10_FB  .Value = (ushort) ( 1 ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 407;
        WaitForInitializationComplete ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    
    SCENE_1 = new Crestron.Logos.SplusObjects.DigitalInput( SCENE_1__DigitalInput__, this );
    m_DigitalInputList.Add( SCENE_1__DigitalInput__, SCENE_1 );
    
    SCENE_2 = new Crestron.Logos.SplusObjects.DigitalInput( SCENE_2__DigitalInput__, this );
    m_DigitalInputList.Add( SCENE_2__DigitalInput__, SCENE_2 );
    
    SCENE_3 = new Crestron.Logos.SplusObjects.DigitalInput( SCENE_3__DigitalInput__, this );
    m_DigitalInputList.Add( SCENE_3__DigitalInput__, SCENE_3 );
    
    SCENE_4 = new Crestron.Logos.SplusObjects.DigitalInput( SCENE_4__DigitalInput__, this );
    m_DigitalInputList.Add( SCENE_4__DigitalInput__, SCENE_4 );
    
    SCENE_5 = new Crestron.Logos.SplusObjects.DigitalInput( SCENE_5__DigitalInput__, this );
    m_DigitalInputList.Add( SCENE_5__DigitalInput__, SCENE_5 );
    
    SCENE_6 = new Crestron.Logos.SplusObjects.DigitalInput( SCENE_6__DigitalInput__, this );
    m_DigitalInputList.Add( SCENE_6__DigitalInput__, SCENE_6 );
    
    SCENE_7 = new Crestron.Logos.SplusObjects.DigitalInput( SCENE_7__DigitalInput__, this );
    m_DigitalInputList.Add( SCENE_7__DigitalInput__, SCENE_7 );
    
    SCENE_8 = new Crestron.Logos.SplusObjects.DigitalInput( SCENE_8__DigitalInput__, this );
    m_DigitalInputList.Add( SCENE_8__DigitalInput__, SCENE_8 );
    
    SCENE_9 = new Crestron.Logos.SplusObjects.DigitalInput( SCENE_9__DigitalInput__, this );
    m_DigitalInputList.Add( SCENE_9__DigitalInput__, SCENE_9 );
    
    SCENE_10 = new Crestron.Logos.SplusObjects.DigitalInput( SCENE_10__DigitalInput__, this );
    m_DigitalInputList.Add( SCENE_10__DigitalInput__, SCENE_10 );
    
    SHOW_LAYER_1 = new Crestron.Logos.SplusObjects.DigitalInput( SHOW_LAYER_1__DigitalInput__, this );
    m_DigitalInputList.Add( SHOW_LAYER_1__DigitalInput__, SHOW_LAYER_1 );
    
    SHOW_LAYER_2 = new Crestron.Logos.SplusObjects.DigitalInput( SHOW_LAYER_2__DigitalInput__, this );
    m_DigitalInputList.Add( SHOW_LAYER_2__DigitalInput__, SHOW_LAYER_2 );
    
    SHOW_LAYER_3 = new Crestron.Logos.SplusObjects.DigitalInput( SHOW_LAYER_3__DigitalInput__, this );
    m_DigitalInputList.Add( SHOW_LAYER_3__DigitalInput__, SHOW_LAYER_3 );
    
    SHOW_LAYER_4 = new Crestron.Logos.SplusObjects.DigitalInput( SHOW_LAYER_4__DigitalInput__, this );
    m_DigitalInputList.Add( SHOW_LAYER_4__DigitalInput__, SHOW_LAYER_4 );
    
    HIDE_LAYER_1 = new Crestron.Logos.SplusObjects.DigitalInput( HIDE_LAYER_1__DigitalInput__, this );
    m_DigitalInputList.Add( HIDE_LAYER_1__DigitalInput__, HIDE_LAYER_1 );
    
    HIDE_LAYER_2 = new Crestron.Logos.SplusObjects.DigitalInput( HIDE_LAYER_2__DigitalInput__, this );
    m_DigitalInputList.Add( HIDE_LAYER_2__DigitalInput__, HIDE_LAYER_2 );
    
    HIDE_LAYER_3 = new Crestron.Logos.SplusObjects.DigitalInput( HIDE_LAYER_3__DigitalInput__, this );
    m_DigitalInputList.Add( HIDE_LAYER_3__DigitalInput__, HIDE_LAYER_3 );
    
    HIDE_LAYER_4 = new Crestron.Logos.SplusObjects.DigitalInput( HIDE_LAYER_4__DigitalInput__, this );
    m_DigitalInputList.Add( HIDE_LAYER_4__DigitalInput__, HIDE_LAYER_4 );
    
    IN_1_LAYER_1 = new Crestron.Logos.SplusObjects.DigitalInput( IN_1_LAYER_1__DigitalInput__, this );
    m_DigitalInputList.Add( IN_1_LAYER_1__DigitalInput__, IN_1_LAYER_1 );
    
    IN_2_LAYER_1 = new Crestron.Logos.SplusObjects.DigitalInput( IN_2_LAYER_1__DigitalInput__, this );
    m_DigitalInputList.Add( IN_2_LAYER_1__DigitalInput__, IN_2_LAYER_1 );
    
    IN_3_LAYER_1 = new Crestron.Logos.SplusObjects.DigitalInput( IN_3_LAYER_1__DigitalInput__, this );
    m_DigitalInputList.Add( IN_3_LAYER_1__DigitalInput__, IN_3_LAYER_1 );
    
    IN_4_LAYER_1 = new Crestron.Logos.SplusObjects.DigitalInput( IN_4_LAYER_1__DigitalInput__, this );
    m_DigitalInputList.Add( IN_4_LAYER_1__DigitalInput__, IN_4_LAYER_1 );
    
    BLANK_LAYER_1 = new Crestron.Logos.SplusObjects.DigitalInput( BLANK_LAYER_1__DigitalInput__, this );
    m_DigitalInputList.Add( BLANK_LAYER_1__DigitalInput__, BLANK_LAYER_1 );
    
    IN_1_LAYER_2 = new Crestron.Logos.SplusObjects.DigitalInput( IN_1_LAYER_2__DigitalInput__, this );
    m_DigitalInputList.Add( IN_1_LAYER_2__DigitalInput__, IN_1_LAYER_2 );
    
    IN_2_LAYER_2 = new Crestron.Logos.SplusObjects.DigitalInput( IN_2_LAYER_2__DigitalInput__, this );
    m_DigitalInputList.Add( IN_2_LAYER_2__DigitalInput__, IN_2_LAYER_2 );
    
    IN_3_LAYER_2 = new Crestron.Logos.SplusObjects.DigitalInput( IN_3_LAYER_2__DigitalInput__, this );
    m_DigitalInputList.Add( IN_3_LAYER_2__DigitalInput__, IN_3_LAYER_2 );
    
    IN_4_LAYER_2 = new Crestron.Logos.SplusObjects.DigitalInput( IN_4_LAYER_2__DigitalInput__, this );
    m_DigitalInputList.Add( IN_4_LAYER_2__DigitalInput__, IN_4_LAYER_2 );
    
    BLANK_LAYER_2 = new Crestron.Logos.SplusObjects.DigitalInput( BLANK_LAYER_2__DigitalInput__, this );
    m_DigitalInputList.Add( BLANK_LAYER_2__DigitalInput__, BLANK_LAYER_2 );
    
    IN_1_LAYER_3 = new Crestron.Logos.SplusObjects.DigitalInput( IN_1_LAYER_3__DigitalInput__, this );
    m_DigitalInputList.Add( IN_1_LAYER_3__DigitalInput__, IN_1_LAYER_3 );
    
    IN_2_LAYER_3 = new Crestron.Logos.SplusObjects.DigitalInput( IN_2_LAYER_3__DigitalInput__, this );
    m_DigitalInputList.Add( IN_2_LAYER_3__DigitalInput__, IN_2_LAYER_3 );
    
    IN_3_LAYER_3 = new Crestron.Logos.SplusObjects.DigitalInput( IN_3_LAYER_3__DigitalInput__, this );
    m_DigitalInputList.Add( IN_3_LAYER_3__DigitalInput__, IN_3_LAYER_3 );
    
    IN_4_LAYER_3 = new Crestron.Logos.SplusObjects.DigitalInput( IN_4_LAYER_3__DigitalInput__, this );
    m_DigitalInputList.Add( IN_4_LAYER_3__DigitalInput__, IN_4_LAYER_3 );
    
    BLANK_LAYER_3 = new Crestron.Logos.SplusObjects.DigitalInput( BLANK_LAYER_3__DigitalInput__, this );
    m_DigitalInputList.Add( BLANK_LAYER_3__DigitalInput__, BLANK_LAYER_3 );
    
    IN_1_LAYER_4 = new Crestron.Logos.SplusObjects.DigitalInput( IN_1_LAYER_4__DigitalInput__, this );
    m_DigitalInputList.Add( IN_1_LAYER_4__DigitalInput__, IN_1_LAYER_4 );
    
    IN_2_LAYER_4 = new Crestron.Logos.SplusObjects.DigitalInput( IN_2_LAYER_4__DigitalInput__, this );
    m_DigitalInputList.Add( IN_2_LAYER_4__DigitalInput__, IN_2_LAYER_4 );
    
    IN_3_LAYER_4 = new Crestron.Logos.SplusObjects.DigitalInput( IN_3_LAYER_4__DigitalInput__, this );
    m_DigitalInputList.Add( IN_3_LAYER_4__DigitalInput__, IN_3_LAYER_4 );
    
    IN_4_LAYER_4 = new Crestron.Logos.SplusObjects.DigitalInput( IN_4_LAYER_4__DigitalInput__, this );
    m_DigitalInputList.Add( IN_4_LAYER_4__DigitalInput__, IN_4_LAYER_4 );
    
    BLANK_LAYER_4 = new Crestron.Logos.SplusObjects.DigitalInput( BLANK_LAYER_4__DigitalInput__, this );
    m_DigitalInputList.Add( BLANK_LAYER_4__DigitalInput__, BLANK_LAYER_4 );
    
    SCENE_1_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SCENE_1_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCENE_1_FB__DigitalOutput__, SCENE_1_FB );
    
    SCENE_2_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SCENE_2_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCENE_2_FB__DigitalOutput__, SCENE_2_FB );
    
    SCENE_3_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SCENE_3_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCENE_3_FB__DigitalOutput__, SCENE_3_FB );
    
    SCENE_4_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SCENE_4_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCENE_4_FB__DigitalOutput__, SCENE_4_FB );
    
    SCENE_5_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SCENE_5_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCENE_5_FB__DigitalOutput__, SCENE_5_FB );
    
    SCENE_6_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SCENE_6_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCENE_6_FB__DigitalOutput__, SCENE_6_FB );
    
    SCENE_7_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SCENE_7_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCENE_7_FB__DigitalOutput__, SCENE_7_FB );
    
    SCENE_8_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SCENE_8_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCENE_8_FB__DigitalOutput__, SCENE_8_FB );
    
    SCENE_9_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SCENE_9_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCENE_9_FB__DigitalOutput__, SCENE_9_FB );
    
    SCENE_10_FB = new Crestron.Logos.SplusObjects.DigitalOutput( SCENE_10_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( SCENE_10_FB__DigitalOutput__, SCENE_10_FB );
    
    SCENE_TRANSITION_TIME = new Crestron.Logos.SplusObjects.AnalogInput( SCENE_TRANSITION_TIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SCENE_TRANSITION_TIME__AnalogSerialInput__, SCENE_TRANSITION_TIME );
    
    RX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( RX__DOLLAR____AnalogSerialInput__, 30, this );
    m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    
    SCENE_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCENE_1_OnPush_0, false ) );
    SCENE_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCENE_2_OnPush_1, false ) );
    SCENE_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCENE_3_OnPush_2, false ) );
    SCENE_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCENE_4_OnPush_3, false ) );
    SCENE_5.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCENE_5_OnPush_4, false ) );
    SCENE_6.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCENE_6_OnPush_5, false ) );
    SCENE_7.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCENE_7_OnPush_6, false ) );
    SCENE_8.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCENE_8_OnPush_7, false ) );
    SCENE_9.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCENE_9_OnPush_8, false ) );
    SCENE_10.OnDigitalPush.Add( new InputChangeHandlerWrapper( SCENE_10_OnPush_9, false ) );
    SHOW_LAYER_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( SHOW_LAYER_1_OnPush_10, false ) );
    SHOW_LAYER_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( SHOW_LAYER_2_OnPush_11, false ) );
    SHOW_LAYER_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( SHOW_LAYER_3_OnPush_12, false ) );
    SHOW_LAYER_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( SHOW_LAYER_4_OnPush_13, false ) );
    HIDE_LAYER_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( HIDE_LAYER_1_OnPush_14, false ) );
    HIDE_LAYER_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( HIDE_LAYER_2_OnPush_15, false ) );
    HIDE_LAYER_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( HIDE_LAYER_3_OnPush_16, false ) );
    HIDE_LAYER_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( HIDE_LAYER_4_OnPush_17, false ) );
    IN_1_LAYER_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_1_LAYER_1_OnPush_18, false ) );
    IN_2_LAYER_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_2_LAYER_1_OnPush_19, false ) );
    IN_3_LAYER_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_3_LAYER_1_OnPush_20, false ) );
    IN_4_LAYER_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_4_LAYER_1_OnPush_21, false ) );
    BLANK_LAYER_1.OnDigitalPush.Add( new InputChangeHandlerWrapper( BLANK_LAYER_1_OnPush_22, false ) );
    IN_1_LAYER_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_1_LAYER_2_OnPush_23, false ) );
    IN_2_LAYER_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_2_LAYER_2_OnPush_24, false ) );
    IN_3_LAYER_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_3_LAYER_2_OnPush_25, false ) );
    IN_4_LAYER_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_4_LAYER_2_OnPush_26, false ) );
    BLANK_LAYER_2.OnDigitalPush.Add( new InputChangeHandlerWrapper( BLANK_LAYER_2_OnPush_27, false ) );
    IN_1_LAYER_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_1_LAYER_3_OnPush_28, false ) );
    IN_2_LAYER_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_2_LAYER_3_OnPush_29, false ) );
    IN_3_LAYER_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_3_LAYER_3_OnPush_30, false ) );
    IN_4_LAYER_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_4_LAYER_3_OnPush_31, false ) );
    BLANK_LAYER_3.OnDigitalPush.Add( new InputChangeHandlerWrapper( BLANK_LAYER_3_OnPush_32, false ) );
    IN_1_LAYER_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_1_LAYER_4_OnPush_33, false ) );
    IN_2_LAYER_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_2_LAYER_4_OnPush_34, false ) );
    IN_3_LAYER_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_3_LAYER_4_OnPush_35, false ) );
    IN_4_LAYER_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( IN_4_LAYER_4_OnPush_36, false ) );
    BLANK_LAYER_4.OnDigitalPush.Add( new InputChangeHandlerWrapper( BLANK_LAYER_4_OnPush_37, false ) );
    SCENE_TRANSITION_TIME.OnAnalogChange.Add( new InputChangeHandlerWrapper( SCENE_TRANSITION_TIME_OnChange_38, false ) );
    RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_39, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_ROLAND_VP_42H_V1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint SCENE_1__DigitalInput__ = 0;
const uint SCENE_2__DigitalInput__ = 1;
const uint SCENE_3__DigitalInput__ = 2;
const uint SCENE_4__DigitalInput__ = 3;
const uint SCENE_5__DigitalInput__ = 4;
const uint SCENE_6__DigitalInput__ = 5;
const uint SCENE_7__DigitalInput__ = 6;
const uint SCENE_8__DigitalInput__ = 7;
const uint SCENE_9__DigitalInput__ = 8;
const uint SCENE_10__DigitalInput__ = 9;
const uint SHOW_LAYER_1__DigitalInput__ = 10;
const uint SHOW_LAYER_2__DigitalInput__ = 11;
const uint SHOW_LAYER_3__DigitalInput__ = 12;
const uint SHOW_LAYER_4__DigitalInput__ = 13;
const uint HIDE_LAYER_1__DigitalInput__ = 14;
const uint HIDE_LAYER_2__DigitalInput__ = 15;
const uint HIDE_LAYER_3__DigitalInput__ = 16;
const uint HIDE_LAYER_4__DigitalInput__ = 17;
const uint IN_1_LAYER_1__DigitalInput__ = 18;
const uint IN_2_LAYER_1__DigitalInput__ = 19;
const uint IN_3_LAYER_1__DigitalInput__ = 20;
const uint IN_4_LAYER_1__DigitalInput__ = 21;
const uint BLANK_LAYER_1__DigitalInput__ = 22;
const uint IN_1_LAYER_2__DigitalInput__ = 23;
const uint IN_2_LAYER_2__DigitalInput__ = 24;
const uint IN_3_LAYER_2__DigitalInput__ = 25;
const uint IN_4_LAYER_2__DigitalInput__ = 26;
const uint BLANK_LAYER_2__DigitalInput__ = 27;
const uint IN_1_LAYER_3__DigitalInput__ = 28;
const uint IN_2_LAYER_3__DigitalInput__ = 29;
const uint IN_3_LAYER_3__DigitalInput__ = 30;
const uint IN_4_LAYER_3__DigitalInput__ = 31;
const uint BLANK_LAYER_3__DigitalInput__ = 32;
const uint IN_1_LAYER_4__DigitalInput__ = 33;
const uint IN_2_LAYER_4__DigitalInput__ = 34;
const uint IN_3_LAYER_4__DigitalInput__ = 35;
const uint IN_4_LAYER_4__DigitalInput__ = 36;
const uint BLANK_LAYER_4__DigitalInput__ = 37;
const uint SCENE_TRANSITION_TIME__AnalogSerialInput__ = 0;
const uint RX__DOLLAR____AnalogSerialInput__ = 1;
const uint SCENE_1_FB__DigitalOutput__ = 0;
const uint SCENE_2_FB__DigitalOutput__ = 1;
const uint SCENE_3_FB__DigitalOutput__ = 2;
const uint SCENE_4_FB__DigitalOutput__ = 3;
const uint SCENE_5_FB__DigitalOutput__ = 4;
const uint SCENE_6_FB__DigitalOutput__ = 5;
const uint SCENE_7_FB__DigitalOutput__ = 6;
const uint SCENE_8_FB__DigitalOutput__ = 7;
const uint SCENE_9_FB__DigitalOutput__ = 8;
const uint SCENE_10_FB__DigitalOutput__ = 9;
const uint TX__DOLLAR____AnalogSerialOutput__ = 0;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
