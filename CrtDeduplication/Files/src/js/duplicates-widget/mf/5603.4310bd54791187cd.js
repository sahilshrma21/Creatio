(self.webpackChunkapp_studio_enterprise_duplicates_widget=self.webpackChunkapp_studio_enterprise_duplicates_widget||[]).push([[5603],{25603:(m,C,p)=>{p.r(C),p.d(C,{ColorSketchModule:()=>d,SketchComponent:()=>r,SketchFieldsComponent:()=>c,SketchPresetColorsComponent:()=>h});var e=p(94450),a=p(77057),b=p(18519),g=p(31134),_=p(34560);const u=function(l,n){return{input:l,label:n}};function x(l,n){if(l&1){const t=e.\u0275\u0275getCurrentView();e.\u0275\u0275elementStart(0,"div",8)(1,"color-editable-input",9),e.\u0275\u0275listener("onChange",function(o){e.\u0275\u0275restoreView(t);const i=e.\u0275\u0275nextContext();return e.\u0275\u0275resetView(i.handleChange(o))}),e.\u0275\u0275elementEnd()()}if(l&2){const t=e.\u0275\u0275nextContext();e.\u0275\u0275advance(1),e.\u0275\u0275styleMap(e.\u0275\u0275pureFunction2(5,u,t.input,t.label)),e.\u0275\u0275property("value",t.round(t.rgb.a*100))("dragLabel",!0)("dragMax",100)}}function v(l,n){if(l&1){const t=e.\u0275\u0275getCurrentView();e.\u0275\u0275elementStart(0,"div",2)(1,"color-swatch",3),e.\u0275\u0275listener("onClick",function(o){e.\u0275\u0275restoreView(t);const i=e.\u0275\u0275nextContext();return e.\u0275\u0275resetView(i.handleClick(o))})("onHover",function(o){e.\u0275\u0275restoreView(t);const i=e.\u0275\u0275nextContext();return e.\u0275\u0275resetView(i.onSwatchHover.emit(o))}),e.\u0275\u0275elementEnd()()}if(l&2){const t=n.$implicit,s=e.\u0275\u0275nextContext();e.\u0275\u0275advance(1),e.\u0275\u0275styleMap(s.swatchStyle),e.\u0275\u0275property("color",s.normalizeValue(t).color)("focusStyle",s.focusStyle(t))}}function f(l,n){if(l&1){const t=e.\u0275\u0275getCurrentView();e.\u0275\u0275elementStart(0,"div",12)(1,"color-alpha",13),e.\u0275\u0275listener("onChange",function(o){e.\u0275\u0275restoreView(t);const i=e.\u0275\u0275nextContext();return e.\u0275\u0275resetView(i.handleValueChange(o))}),e.\u0275\u0275elementEnd()()}if(l&2){const t=e.\u0275\u0275nextContext();e.\u0275\u0275advance(1),e.\u0275\u0275property("radius",2)("rgb",t.rgb)("hsl",t.hsl)}}function k(l,n){if(l&1){const t=e.\u0275\u0275getCurrentView();e.\u0275\u0275elementStart(0,"div",14)(1,"color-sketch-preset-colors",15),e.\u0275\u0275listener("onClick",function(o){e.\u0275\u0275restoreView(t);const i=e.\u0275\u0275nextContext();return e.\u0275\u0275resetView(i.handleBlockChange(o))})("onSwatchHover",function(o){e.\u0275\u0275restoreView(t);const i=e.\u0275\u0275nextContext();return e.\u0275\u0275resetView(i.onSwatchHover.emit(o))}),e.\u0275\u0275elementEnd()()}if(l&2){const t=e.\u0275\u0275nextContext();e.\u0275\u0275advance(1),e.\u0275\u0275property("colors",t.presetColors)}}class c{constructor(){this.disableAlpha=!1,this.onChange=new e.EventEmitter,this.input={width:"100%",padding:"4px 10% 3px",border:"none",boxSizing:"border-box",boxShadow:"inset 0 0 0 1px #ccc",fontSize:"11px"},this.label={display:"block",textAlign:"center",fontSize:"11px",color:"#222",paddingTop:"3px",paddingBottom:"4px",textTransform:"capitalize"}}round(n){return Math.round(n)}handleChange({data:n,$event:t}){if(n.hex){if((0,a.isValidHex)(n.hex)){const s=new b.C(n.hex);this.onChange.emit({data:{hex:this.disableAlpha||n.hex.length<=6?s.toHex():s.toHex8(),source:"hex"},$event:t})}}else n.r||n.g||n.b?this.onChange.emit({data:{r:n.r||this.rgb.r,g:n.g||this.rgb.g,b:n.b||this.rgb.b,source:"rgb"},$event:t}):n.a?(n.a<0?n.a=0:n.a>100&&(n.a=100),n.a/=100,this.disableAlpha&&(n.a=1),this.onChange.emit({data:{h:this.hsl.h,s:this.hsl.s,l:this.hsl.l,a:Math.round(n.a*100)/100,source:"rgb"},$event:t})):(n.h||n.s||n.l)&&this.onChange.emit({data:{h:n.h||this.hsl.h,s:Number(n.s&&n.s||this.hsl.s),l:Number(n.l&&n.l||this.hsl.l),source:"hsl"},$event:t})}}c.\u0275fac=function(n){return new(n||c)},c.\u0275cmp=e.\u0275\u0275defineComponent({type:c,selectors:[["color-sketch-fields"]],inputs:{hsl:"hsl",rgb:"rgb",hex:"hex",disableAlpha:"disableAlpha"},outputs:{onChange:"onChange"},decls:10,vars:31,consts:[[1,"sketch-fields"],[1,"sketch-double"],["label","hex",3,"value","onChange"],[1,"sketch-single"],["label","r",3,"value","dragLabel","dragMax","onChange"],["label","g",3,"value","dragLabel","dragMax","onChange"],["label","b",3,"value","dragLabel","dragMax","onChange"],["class","sketch-alpha",4,"ngIf"],[1,"sketch-alpha"],["label","a",3,"value","dragLabel","dragMax","onChange"]],template:function(n,t){n&1&&(e.\u0275\u0275elementStart(0,"div",0)(1,"div",1)(2,"color-editable-input",2),e.\u0275\u0275listener("onChange",function(o){return t.handleChange(o)}),e.\u0275\u0275elementEnd()(),e.\u0275\u0275elementStart(3,"div",3)(4,"color-editable-input",4),e.\u0275\u0275listener("onChange",function(o){return t.handleChange(o)}),e.\u0275\u0275elementEnd()(),e.\u0275\u0275elementStart(5,"div",3)(6,"color-editable-input",5),e.\u0275\u0275listener("onChange",function(o){return t.handleChange(o)}),e.\u0275\u0275elementEnd()(),e.\u0275\u0275elementStart(7,"div",3)(8,"color-editable-input",6),e.\u0275\u0275listener("onChange",function(o){return t.handleChange(o)}),e.\u0275\u0275elementEnd()(),e.\u0275\u0275template(9,x,2,8,"div",7),e.\u0275\u0275elementEnd()),n&2&&(e.\u0275\u0275advance(2),e.\u0275\u0275styleMap(e.\u0275\u0275pureFunction2(19,u,t.input,t.label)),e.\u0275\u0275property("value",t.hex.replace("#","")),e.\u0275\u0275advance(2),e.\u0275\u0275styleMap(e.\u0275\u0275pureFunction2(22,u,t.input,t.label)),e.\u0275\u0275property("value",t.rgb.r)("dragLabel",!0)("dragMax",255),e.\u0275\u0275advance(2),e.\u0275\u0275styleMap(e.\u0275\u0275pureFunction2(25,u,t.input,t.label)),e.\u0275\u0275property("value",t.rgb.g)("dragLabel",!0)("dragMax",255),e.\u0275\u0275advance(2),e.\u0275\u0275styleMap(e.\u0275\u0275pureFunction2(28,u,t.input,t.label)),e.\u0275\u0275property("value",t.rgb.b)("dragLabel",!0)("dragMax",255),e.\u0275\u0275advance(1),e.\u0275\u0275property("ngIf",t.disableAlpha===!1))},dependencies:[a.EditableInputComponent,g.NgIf],styles:[".sketch-fields[_ngcontent-%COMP%]{display:flex;padding-top:4px}.sketch-double[_ngcontent-%COMP%]{flex:2 1 0%}.sketch-single[_ngcontent-%COMP%]{flex:1 1 0%;padding-left:6px}.sketch-alpha[_ngcontent-%COMP%]{flex:1 1 0%;padding-left:6px}[dir=rtl][_nghost-%COMP%]   .sketch-single[_ngcontent-%COMP%], [dir=rtl]   [_nghost-%COMP%]   .sketch-single[_ngcontent-%COMP%]{padding-right:6px;padding-left:0}[dir=rtl][_nghost-%COMP%]   .sketch-alpha[_ngcontent-%COMP%], [dir=rtl]   [_nghost-%COMP%]   .sketch-alpha[_ngcontent-%COMP%]{padding-right:6px;padding-left:0}"],changeDetection:0}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(c,[{type:e.Component,args:[{selector:"color-sketch-fields",template:`
  <div class="sketch-fields">
    <div class="sketch-double">
      <color-editable-input
        [style]="{ input: input, label: label }"
        label="hex"
        [value]="hex.replace('#', '')"
        (onChange)="handleChange($event)"
      ></color-editable-input>
    </div>
    <div class="sketch-single">
      <color-editable-input
        [style]="{ input: input, label: label }"
        label="r"
        [value]="rgb.r"
        (onChange)="handleChange($event)"
        [dragLabel]="true"
        [dragMax]="255"
      ></color-editable-input>
    </div>
    <div class="sketch-single">
      <color-editable-input
        [style]="{ input: input, label: label }"
        label="g"
        [value]="rgb.g"
        (onChange)="handleChange($event)"
        [dragLabel]="true"
        [dragMax]="255"
      ></color-editable-input>
    </div>
    <div class="sketch-single">
      <color-editable-input
        [style]="{ input: input, label: label }"
        label="b"
        [value]="rgb.b"
        (onChange)="handleChange($event)"
        [dragLabel]="true"
        [dragMax]="255"
      ></color-editable-input>
    </div>
    <div class="sketch-alpha" *ngIf="disableAlpha === false">
      <color-editable-input
        [style]="{ input: input, label: label }"
        label="a"
        [value]="round(rgb.a * 100)"
        (onChange)="handleChange($event)"
        [dragLabel]="true"
        [dragMax]="100"
      ></color-editable-input>
    </div>
  </div>
  `,styles:[`
    .sketch-fields {
      display: flex;
      padding-top: 4px;
    }
    .sketch-double {
      -webkit-box-flex: 2;
      flex: 2 1 0%;
    }
    .sketch-single {
      flex: 1 1 0%;
      padding-left: 6px;
    }
    .sketch-alpha {
      -webkit-box-flex: 1;
      flex: 1 1 0%;
      padding-left: 6px;
    }
    :host-context([dir=rtl]) .sketch-single {
      padding-right: 6px;
      padding-left: 0;
    }
    :host-context([dir=rtl]) .sketch-alpha {
      padding-right: 6px;
      padding-left: 0;
    }
  `],changeDetection:e.ChangeDetectionStrategy.OnPush,preserveWhitespaces:!1}]}],null,{hsl:[{type:e.Input}],rgb:[{type:e.Input}],hex:[{type:e.Input}],disableAlpha:[{type:e.Input}],onChange:[{type:e.Output}]})}();class h{constructor(){this.onClick=new e.EventEmitter,this.onSwatchHover=new e.EventEmitter,this.swatchStyle={borderRadius:"3px",boxShadow:"inset 0 0 0 1px rgba(0,0,0,.15)"}}handleClick({hex:n,$event:t}){this.onClick.emit({hex:n,$event:t})}normalizeValue(n){return typeof n=="string"?{color:n}:n}focusStyle(n){return{boxShadow:`inset 0 0 0 1px rgba(0,0,0,.15), 0 0 4px ${this.normalizeValue(n).color}`}}}h.\u0275fac=function(n){return new(n||h)},h.\u0275cmp=e.\u0275\u0275defineComponent({type:h,selectors:[["color-sketch-preset-colors"]],inputs:{colors:"colors"},outputs:{onClick:"onClick",onSwatchHover:"onSwatchHover"},decls:2,vars:1,consts:[[1,"sketch-swatches"],["class","sketch-wrap",4,"ngFor","ngForOf"],[1,"sketch-wrap"],[1,"swatch",3,"color","focusStyle","onClick","onHover"]],template:function(n,t){n&1&&(e.\u0275\u0275elementStart(0,"div",0),e.\u0275\u0275template(1,v,2,4,"div",1),e.\u0275\u0275elementEnd()),n&2&&(e.\u0275\u0275advance(1),e.\u0275\u0275property("ngForOf",t.colors))},dependencies:[a.SwatchComponent,g.NgForOf],styles:[".sketch-swatches[_ngcontent-%COMP%]{position:relative;display:flex;flex-wrap:wrap;margin:0 -10px;padding:10px 0 0 10px;border-top:1px solid rgb(238,238,238)}.sketch-wrap[_ngcontent-%COMP%]{width:16px;height:16px;margin:0 10px 10px 0}[dir=rtl][_nghost-%COMP%]   .sketch-swatches[_ngcontent-%COMP%], [dir=rtl]   [_nghost-%COMP%]   .sketch-swatches[_ngcontent-%COMP%]{padding-right:10px;padding-left:0}[dir=rtl][_nghost-%COMP%]   .sketch-wrap[_ngcontent-%COMP%], [dir=rtl]   [_nghost-%COMP%]   .sketch-wrap[_ngcontent-%COMP%]{margin-left:10px;margin-right:0}"],changeDetection:0}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(h,[{type:e.Component,args:[{selector:"color-sketch-preset-colors",template:`
  <div class="sketch-swatches">
    <div class="sketch-wrap" *ngFor="let c of colors">
      <color-swatch
        [color]="normalizeValue(c).color"
        [style]="swatchStyle"
        [focusStyle]="focusStyle(c)"
        (onClick)="handleClick($event)"
        (onHover)="onSwatchHover.emit($event)"
        class="swatch"
      ></color-swatch>
    </div>
  </div>
  `,styles:[`
    .sketch-swatches {
      position: relative;
      display: flex;
      flex-wrap: wrap;
      margin: 0px -10px;
      padding: 10px 0px 0px 10px;
      border-top: 1px solid rgb(238, 238, 238);
    }
    .sketch-wrap {
      width: 16px;
      height: 16px;
      margin: 0px 10px 10px 0px;
    }
    :host-context([dir=rtl]) .sketch-swatches {
      padding-right: 10px;
      padding-left: 0;
    }
    :host-context([dir=rtl]) .sketch-wrap {
      margin-left: 10px;
      margin-right: 0;
    }
  `],changeDetection:e.ChangeDetectionStrategy.OnPush,preserveWhitespaces:!1}]}],null,{colors:[{type:e.Input}],onClick:[{type:e.Output}],onSwatchHover:[{type:e.Output}]})}();class r extends a.ColorWrap{constructor(){super(),this.disableAlpha=!1,this.presetColors=["#D0021B","#F5A623","#F8E71C","#8B572A","#7ED321","#417505","#BD10E0","#9013FE","#4A90E2","#50E3C2","#B8E986","#000000","#4A4A4A","#9B9B9B","#FFFFFF"],this.width=200}afterValidChange(){const n=this.disableAlpha?1:this.rgb.a;this.activeBackground=`rgba(${this.rgb.r}, ${this.rgb.g}, ${this.rgb.b}, ${n})`}handleValueChange({data:n,$event:t}){this.handleChange(n,t)}handleBlockChange({hex:n,$event:t}){(0,a.isValidHex)(n)&&this.handleChange({hex:n,source:"hex"},t)}}r.\u0275fac=function(n){return new(n||r)},r.\u0275cmp=e.\u0275\u0275defineComponent({type:r,selectors:[["color-sketch"]],inputs:{disableAlpha:"disableAlpha",presetColors:"presetColors",width:"width"},features:[e.\u0275\u0275ProvidersFeature([{provide:_.NG_VALUE_ACCESSOR,useExisting:(0,e.forwardRef)(()=>r),multi:!0},{provide:a.ColorWrap,useExisting:(0,e.forwardRef)(()=>r)}]),e.\u0275\u0275InheritDefinitionFeature],decls:14,vars:16,consts:[[1,"sketch-saturation"],[3,"hsl","hsv","onChange"],[1,"sketch-controls"],[1,"sketch-sliders"],[1,"sketch-hue"],[3,"hsl","onChange"],["class","sketch-alpha",4,"ngIf"],[1,"sketch-color"],[1,"sketch-active"],[1,"sketch-fields-container"],[3,"rgb","hsl","hex","disableAlpha","onChange"],["class","sketch-swatches-container",4,"ngIf"],[1,"sketch-alpha"],[3,"radius","rgb","hsl","onChange"],[1,"sketch-swatches-container"],[3,"colors","onClick","onSwatchHover"]],template:function(n,t){n&1&&(e.\u0275\u0275elementStart(0,"div")(1,"div",0)(2,"color-saturation",1),e.\u0275\u0275listener("onChange",function(o){return t.handleValueChange(o)}),e.\u0275\u0275elementEnd()(),e.\u0275\u0275elementStart(3,"div",2)(4,"div",3)(5,"div",4)(6,"color-hue",5),e.\u0275\u0275listener("onChange",function(o){return t.handleValueChange(o)}),e.\u0275\u0275elementEnd()(),e.\u0275\u0275template(7,f,2,3,"div",6),e.\u0275\u0275elementEnd(),e.\u0275\u0275elementStart(8,"div",7),e.\u0275\u0275element(9,"color-checkboard")(10,"div",8),e.\u0275\u0275elementEnd()(),e.\u0275\u0275elementStart(11,"div",9)(12,"color-sketch-fields",10),e.\u0275\u0275listener("onChange",function(o){return t.handleValueChange(o)}),e.\u0275\u0275elementEnd()(),e.\u0275\u0275template(13,k,2,1,"div",11),e.\u0275\u0275elementEnd()),n&2&&(e.\u0275\u0275classMapInterpolate1("sketch-picker ",t.className,""),e.\u0275\u0275styleProp("width",t.width),e.\u0275\u0275advance(2),e.\u0275\u0275property("hsl",t.hsl)("hsv",t.hsv),e.\u0275\u0275advance(4),e.\u0275\u0275property("hsl",t.hsl),e.\u0275\u0275advance(1),e.\u0275\u0275property("ngIf",t.disableAlpha===!1),e.\u0275\u0275advance(3),e.\u0275\u0275styleProp("background",t.activeBackground),e.\u0275\u0275advance(2),e.\u0275\u0275property("rgb",t.rgb)("hsl",t.hsl)("hex",t.hex)("disableAlpha",t.disableAlpha),e.\u0275\u0275advance(1),e.\u0275\u0275property("ngIf",t.presetColors&&t.presetColors.length))},dependencies:function(){return[a.SaturationComponent,a.HueComponent,a.AlphaComponent,a.CheckboardComponent,c,h,g.NgIf]},styles:[".sketch-picker[_ngcontent-%COMP%]{padding:10px 10px 3px;box-sizing:initial;background:#fff;border-radius:4px;box-shadow:0 0 0 1px #00000026,0 8px 16px #00000026}.sketch-saturation[_ngcontent-%COMP%]{width:100%;padding-bottom:75%;position:relative;overflow:hidden}.sketch-fields-container[_ngcontent-%COMP%]{display:block}.sketch-swatches-container[_ngcontent-%COMP%]{display:block}.sketch-controls[_ngcontent-%COMP%]{display:flex}.sketch-sliders[_ngcontent-%COMP%]{padding:4px 0;flex:1 1 0%}.sketch-hue[_ngcontent-%COMP%]{position:relative;height:10px;overflow:hidden}.sketch-alpha[_ngcontent-%COMP%]{position:relative;height:10px;margin-top:4px;overflow:hidden}.sketch-color[_ngcontent-%COMP%]{width:24px;height:24px;position:relative;margin-top:4px;margin-left:4px;border-radius:3px}.sketch-active[_ngcontent-%COMP%]{position:absolute;top:0px;right:0px;bottom:0px;left:0px;border-radius:2px;box-shadow:#00000026 0 0 0 1px inset,#00000040 0 0 4px inset}[dir=rtl][_nghost-%COMP%]   .sketch-color[_ngcontent-%COMP%], [dir=rtl]   [_nghost-%COMP%]   .sketch-color[_ngcontent-%COMP%]{margin-right:4px;margin-left:0}"],changeDetection:0}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(r,[{type:e.Component,args:[{selector:"color-sketch",template:`
  <div class="sketch-picker {{ className }}" [style.width]="width">
    <div class="sketch-saturation">
      <color-saturation [hsl]="hsl" [hsv]="hsv"
        (onChange)="handleValueChange($event)"
      >
      </color-saturation>
    </div>
    <div class="sketch-controls">
      <div class="sketch-sliders">
        <div class="sketch-hue">
          <color-hue [hsl]="hsl"
            (onChange)="handleValueChange($event)"
          ></color-hue>
        </div>
        <div class="sketch-alpha" *ngIf="disableAlpha === false">
          <color-alpha
            [radius]="2" [rgb]="rgb" [hsl]="hsl"
            (onChange)="handleValueChange($event)"
          ></color-alpha>
        </div>
      </div>
      <div class="sketch-color">
        <color-checkboard></color-checkboard>
        <div class="sketch-active" [style.background]="activeBackground"></div>
      </div>
    </div>
    <div class="sketch-fields-container">
      <color-sketch-fields
        [rgb]="rgb" [hsl]="hsl" [hex]="hex"
        [disableAlpha]="disableAlpha"
        (onChange)="handleValueChange($event)"
      ></color-sketch-fields>
    </div>
    <div class="sketch-swatches-container" *ngIf="presetColors && presetColors.length">
      <color-sketch-preset-colors
        [colors]="presetColors"
        (onClick)="handleBlockChange($event)"
        (onSwatchHover)="onSwatchHover.emit($event)"
      ></color-sketch-preset-colors>
    </div>
  </div>
  `,styles:[`
    .sketch-picker {
      padding: 10px 10px 3px;
      box-sizing: initial;
      background: #fff;
      border-radius: 4px;
      box-shadow: 0 0 0 1px rgba(0,0,0,.15), 0 8px 16px rgba(0,0,0,.15);
    }
    .sketch-saturation {
      width: 100%;
      padding-bottom: 75%;
      position: relative;
      overflow: hidden;
    }
    .sketch-fields-container {
      display: block;
    }
    .sketch-swatches-container {
      display: block;
    }
    .sketch-controls {
      display: flex;
    }
    .sketch-sliders {
      padding: 4px 0px;
      -webkit-box-flex: 1;
      flex: 1 1 0%;
    }
    .sketch-hue {
      position: relative;
      height: 10px;
      overflow: hidden;
    }
    .sketch-alpha {
      position: relative;
      height: 10px;
      margin-top: 4px;
      overflow: hidden;
    }
    .sketch-color {
      width: 24px;
      height: 24px;
      position: relative;
      margin-top: 4px;
      margin-left: 4px;
      border-radius: 3px;
    }
    .sketch-active {
      position: absolute;
      top: 0px;
      right: 0px;
      bottom: 0px;
      left: 0px;
      border-radius: 2px;
      box-shadow: rgba(0, 0, 0, 0.15) 0px 0px 0px 1px inset, rgba(0, 0, 0, 0.25) 0px 0px 4px inset;
    }
    :host-context([dir=rtl]) .sketch-color {
      margin-right: 4px;
      margin-left: 0;
    }
  `],changeDetection:e.ChangeDetectionStrategy.OnPush,preserveWhitespaces:!1,providers:[{provide:_.NG_VALUE_ACCESSOR,useExisting:(0,e.forwardRef)(()=>r),multi:!0},{provide:a.ColorWrap,useExisting:(0,e.forwardRef)(()=>r)}]}]}],function(){return[]},{disableAlpha:[{type:e.Input}],presetColors:[{type:e.Input}],width:[{type:e.Input}]})}();class d{}d.\u0275fac=function(n){return new(n||d)},d.\u0275mod=e.\u0275\u0275defineNgModule({type:d}),d.\u0275inj=e.\u0275\u0275defineInjector({imports:[[g.CommonModule,a.AlphaModule,a.CheckboardModule,a.EditableInputModule,a.HueModule,a.SaturationModule,a.SwatchModule]]}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(d,[{type:e.NgModule,args:[{declarations:[r,c,h],exports:[r,c,h],imports:[g.CommonModule,a.AlphaModule,a.CheckboardModule,a.EditableInputModule,a.HueModule,a.SaturationModule,a.SwatchModule]}]}],null,null)}()}}]);
