(self.webpackChunkapp_studio_enterprise_duplicates_widget=self.webpackChunkapp_studio_enterprise_duplicates_widget||[]).push([[6295],{14630:(q,j,m)=>{m.r(j),m.d(j,{AlphaComponent:()=>b,AlphaModule:()=>x,CheckboardComponent:()=>g,CheckboardModule:()=>h,ColorMode:()=>C,ColorWrap:()=>f,ColorWrapModule:()=>D,CoordinatesDirective:()=>u,CoordinatesModule:()=>p,EditableInputComponent:()=>y,EditableInputModule:()=>k,HueComponent:()=>v,HueModule:()=>O,RaisedComponent:()=>w,RaisedModule:()=>I,SaturationComponent:()=>_,SaturationModule:()=>E,ShadeComponent:()=>S,ShadeModule:()=>H,SwatchComponent:()=>M,SwatchModule:()=>P,getCheckerboard:()=>W,getContrastingColor:()=>Y,isValidHex:()=>K,render:()=>A,simpleCheckForValidColor:()=>R,toState:()=>F});var r=m(31134),e=m(94450),N=m(21322),T=m(27049),L=m(18519),$=m(34560);function B(s,t){if(s&1){const n=e.\u0275\u0275getCurrentView();e.\u0275\u0275elementStart(0,"span",3),e.\u0275\u0275listener("mousedown",function(o){e.\u0275\u0275restoreView(n);const l=e.\u0275\u0275nextContext();return e.\u0275\u0275resetView(l.handleMousedown(o))}),e.\u0275\u0275text(1),e.\u0275\u0275elementEnd()}if(s&2){const n=e.\u0275\u0275nextContext();e.\u0275\u0275property("id",n.uniqueId)("ngStyle",n.labelStyle),e.\u0275\u0275advance(1),e.\u0275\u0275textInterpolate1(" ",n.label," ")}}function X(s,t){if(s&1&&(e.\u0275\u0275elementStart(0,"div",2),e.\u0275\u0275element(1,"div",3),e.\u0275\u0275elementEnd()),s&2){const n=e.\u0275\u0275nextContext();e.\u0275\u0275styleProp("left",n.left)("top",n.top),e.\u0275\u0275advance(1),e.\u0275\u0275property("ngStyle",n.pointer)}}const z=["*"];function U(s,t){s&1&&e.\u0275\u0275element(0,"color-checkboard",2)}const V={};function A(s,t,n){if(typeof document>"u")return null;const i=document.createElement("canvas");i.width=n*2,i.height=n*2;const o=i.getContext("2d");return o?(o.fillStyle=s,o.fillRect(0,0,i.width,i.height),o.fillStyle=t,o.fillRect(0,0,n,n),o.translate(n,n),o.fillRect(0,0,n,n),i.toDataURL()):null}function W(s,t,n){const i=`${s}-${t}-${n}`;if(V[i])return V[i];const o=A(s,t,n);return o?(V[i]=o,o):null}class g{constructor(){this.white="transparent",this.size=8,this.grey="rgba(0,0,0,.08)"}ngOnInit(){const t=W(this.white,this.grey,this.size);this.gridStyles={borderRadius:this.borderRadius,boxShadow:this.boxShadow,background:`url(${t}) center left`}}}g.\u0275fac=function(t){return new(t||g)},g.\u0275cmp=e.\u0275\u0275defineComponent({type:g,selectors:[["color-checkboard"]],inputs:{white:"white",size:"size",grey:"grey",boxShadow:"boxShadow",borderRadius:"borderRadius"},decls:1,vars:1,consts:[[1,"grid",3,"ngStyle"]],template:function(t,n){t&1&&e.\u0275\u0275element(0,"div",0),t&2&&e.\u0275\u0275property("ngStyle",n.gridStyles)},dependencies:[r.NgStyle],styles:[".grid[_ngcontent-%COMP%]{top:0px;right:0px;bottom:0px;left:0px;position:absolute}"],changeDetection:0}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(g,[{type:e.Component,args:[{selector:"color-checkboard",template:'<div class="grid" [ngStyle]="gridStyles"></div>',styles:[`
  .grid {
    top: 0px;
    right: 0px;
    bottom: 0px;
    left: 0px;
    position: absolute;
  }
  `],preserveWhitespaces:!1,changeDetection:e.ChangeDetectionStrategy.OnPush}]}],null,{white:[{type:e.Input}],size:[{type:e.Input}],grey:[{type:e.Input}],boxShadow:[{type:e.Input}],borderRadius:[{type:e.Input}]})}();class h{}h.\u0275fac=function(t){return new(t||h)},h.\u0275mod=e.\u0275\u0275defineNgModule({type:h}),h.\u0275inj=e.\u0275\u0275defineInjector({imports:[[r.CommonModule]]}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(h,[{type:e.NgModule,args:[{declarations:[g],exports:[g],imports:[r.CommonModule]}]}],null,null)}();class u{constructor(t){this.el=t,this.coordinatesChange=new N.Subject,this.mousechange=new N.Subject,this.mouseListening=!1}mousemove(t,n,i,o=!1){this.mouseListening&&(t.preventDefault(),this.mousechange.next({$event:t,x:n,y:i,isTouch:o}))}mouseup(){this.mouseListening=!1}mousedown(t,n,i,o=!1){t.preventDefault(),this.mouseListening=!0,this.mousechange.next({$event:t,x:n,y:i,isTouch:o})}ngOnInit(){this.sub=this.mousechange.pipe((0,T.distinctUntilChanged)((t,n)=>t.x===n.x&&t.y===n.y)).subscribe(t=>this.handleChange(t.x,t.y,t.$event,t.isTouch))}ngOnDestroy(){this.sub.unsubscribe()}handleChange(t,n,i,o){const l=this.el.nativeElement.clientWidth,d=this.el.nativeElement.clientHeight,a=t-(this.el.nativeElement.getBoundingClientRect().left+window.pageXOffset);let c=n-this.el.nativeElement.getBoundingClientRect().top;o||(c=c-window.pageYOffset),this.coordinatesChange.next({x:t,y:n,top:c,left:a,containerWidth:l,containerHeight:d,$event:i})}}u.\u0275fac=function(t){return new(t||u)(e.\u0275\u0275directiveInject(e.ElementRef))},u.\u0275dir=e.\u0275\u0275defineDirective({type:u,selectors:[["","ngx-color-coordinates",""]],hostBindings:function(t,n){t&1&&e.\u0275\u0275listener("mousemove",function(o){return n.mousemove(o,o.pageX,o.pageY)},!1,e.\u0275\u0275resolveWindow)("touchmove",function(o){return n.mousemove(o,o.touches[0].clientX,o.touches[0].clientY,!0)},!1,e.\u0275\u0275resolveWindow)("mouseup",function(){return n.mouseup()},!1,e.\u0275\u0275resolveWindow)("touchend",function(){return n.mouseup()},!1,e.\u0275\u0275resolveWindow)("mousedown",function(o){return n.mousedown(o,o.pageX,o.pageY)})("touchstart",function(o){return n.mousedown(o,o.touches[0].clientX,o.touches[0].clientY,!0)})},outputs:{coordinatesChange:"coordinatesChange"}}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(u,[{type:e.Directive,args:[{selector:"[ngx-color-coordinates]"}]}],function(){return[{type:e.ElementRef}]},{coordinatesChange:[{type:e.Output}],mousemove:[{type:e.HostListener,args:["window:mousemove",["$event","$event.pageX","$event.pageY"]]},{type:e.HostListener,args:["window:touchmove",["$event","$event.touches[0].clientX","$event.touches[0].clientY","true"]]}],mouseup:[{type:e.HostListener,args:["window:mouseup"]},{type:e.HostListener,args:["window:touchend"]}],mousedown:[{type:e.HostListener,args:["mousedown",["$event","$event.pageX","$event.pageY"]]},{type:e.HostListener,args:["touchstart",["$event","$event.touches[0].clientX","$event.touches[0].clientY","true"]]}]})}();class p{}p.\u0275fac=function(t){return new(t||p)},p.\u0275mod=e.\u0275\u0275defineNgModule({type:p}),p.\u0275inj=e.\u0275\u0275defineInjector({}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(p,[{type:e.NgModule,args:[{declarations:[u],exports:[u]}]}],null,null)}();class b{constructor(){this.direction="horizontal",this.onChange=new e.EventEmitter}ngOnChanges(){this.direction==="vertical"?(this.pointerLeft=0,this.pointerTop=this.rgb.a*100,this.gradient={background:`linear-gradient(to bottom, rgba(${this.rgb.r},${this.rgb.g},${this.rgb.b}, 0) 0%,
          rgba(${this.rgb.r},${this.rgb.g},${this.rgb.b}, 1) 100%)`}):(this.gradient={background:`linear-gradient(to right, rgba(${this.rgb.r},${this.rgb.g},${this.rgb.b}, 0) 0%,
          rgba(${this.rgb.r},${this.rgb.g},${this.rgb.b}, 1) 100%)`},this.pointerLeft=this.rgb.a*100)}handleChange({top:t,left:n,containerHeight:i,containerWidth:o,$event:l}){let d;if(this.direction==="vertical"){let a;t<0?a=0:t>i?a=1:a=Math.round(t*100/i)/100,this.hsl.a!==a&&(d={h:this.hsl.h,s:this.hsl.s,l:this.hsl.l,a,source:"rgb"})}else{let a;n<0?a=0:n>o?a=1:a=Math.round(n*100/o)/100,this.hsl.a!==a&&(d={h:this.hsl.h,s:this.hsl.s,l:this.hsl.l,a,source:"rgb"})}!d||this.onChange.emit({data:d,$event:l})}}b.\u0275fac=function(t){return new(t||b)},b.\u0275cmp=e.\u0275\u0275defineComponent({type:b,selectors:[["color-alpha"]],inputs:{hsl:"hsl",rgb:"rgb",pointer:"pointer",shadow:"shadow",radius:"radius",direction:"direction"},outputs:{onChange:"onChange"},features:[e.\u0275\u0275NgOnChangesFeature],decls:7,vars:15,consts:[[1,"alpha"],[1,"alpha-checkboard"],[1,"alpha-gradient",3,"ngStyle"],["ngx-color-coordinates","",3,"coordinatesChange"],[1,"alpha-pointer"],[1,"alpha-slider",3,"ngStyle"]],template:function(t,n){t&1&&(e.\u0275\u0275elementStart(0,"div",0)(1,"div",1),e.\u0275\u0275element(2,"color-checkboard"),e.\u0275\u0275elementEnd(),e.\u0275\u0275element(3,"div",2),e.\u0275\u0275elementStart(4,"div",3),e.\u0275\u0275listener("coordinatesChange",function(o){return n.handleChange(o)}),e.\u0275\u0275elementStart(5,"div",4),e.\u0275\u0275element(6,"div",5),e.\u0275\u0275elementEnd()()()),t&2&&(e.\u0275\u0275styleProp("border-radius",n.radius),e.\u0275\u0275advance(3),e.\u0275\u0275styleProp("box-shadow",n.shadow)("border-radius",n.radius),e.\u0275\u0275property("ngStyle",n.gradient),e.\u0275\u0275advance(1),e.\u0275\u0275classMapInterpolate1("alpha-container color-alpha-",n.direction,""),e.\u0275\u0275advance(1),e.\u0275\u0275styleProp("left",n.pointerLeft,"%")("top",n.pointerTop,"%"),e.\u0275\u0275advance(1),e.\u0275\u0275property("ngStyle",n.pointer))},dependencies:[g,r.NgStyle,u],styles:[".alpha[_ngcontent-%COMP%]{position:absolute;top:0;bottom:0;left:0;right:0}.alpha-checkboard[_ngcontent-%COMP%]{position:absolute;top:0;bottom:0;left:0;right:0;overflow:hidden}.alpha-gradient[_ngcontent-%COMP%]{position:absolute;top:0;bottom:0;left:0;right:0}.alpha-container[_ngcontent-%COMP%]{position:relative;height:100%;margin:0 3px}.alpha-pointer[_ngcontent-%COMP%]{position:absolute}.alpha-slider[_ngcontent-%COMP%]{width:4px;border-radius:1px;height:8px;box-shadow:0 0 2px #0009;background:#fff;margin-top:1px;transform:translate(-2px)}"],changeDetection:0}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(b,[{type:e.Component,args:[{selector:"color-alpha",template:`
  <div class="alpha" [style.border-radius]="radius">
    <div class="alpha-checkboard">
      <color-checkboard></color-checkboard>
    </div>
    <div class="alpha-gradient" [ngStyle]="gradient" [style.box-shadow]="shadow" [style.border-radius]="radius"></div>
    <div ngx-color-coordinates (coordinatesChange)="handleChange($event)" class="alpha-container color-alpha-{{direction}}">
      <div class="alpha-pointer" [style.left.%]="pointerLeft" [style.top.%]="pointerTop">
        <div class="alpha-slider" [ngStyle]="pointer"></div>
      </div>
    </div>
  </div>
  `,styles:[`
    .alpha {
      position: absolute;
      top: 0;
      bottom: 0;
      left: 0;
      right: 0;
    }
    .alpha-checkboard {
      position: absolute;
      top: 0;
      bottom: 0;
      left: 0;
      right: 0;
      overflow: hidden;
    }
    .alpha-gradient {
      position: absolute;
      top: 0;
      bottom: 0;
      left: 0;
      right: 0;
    }
    .alpha-container {
      position: relative;
      height: 100%;
      margin: 0 3px;
    }
    .alpha-pointer {
      position: absolute;
    }
    .alpha-slider {
      width: 4px;
      border-radius: 1px;
      height: 8px;
      box-shadow: 0 0 2px rgba(0, 0, 0, .6);
      background: #fff;
      margin-top: 1px;
      transform: translateX(-2px);
    }
  `],changeDetection:e.ChangeDetectionStrategy.OnPush,preserveWhitespaces:!1}]}],null,{hsl:[{type:e.Input}],rgb:[{type:e.Input}],pointer:[{type:e.Input}],shadow:[{type:e.Input}],radius:[{type:e.Input}],direction:[{type:e.Input}],onChange:[{type:e.Output}]})}();class x{}x.\u0275fac=function(t){return new(t||x)},x.\u0275mod=e.\u0275\u0275defineNgModule({type:x}),x.\u0275inj=e.\u0275\u0275defineInjector({imports:[[r.CommonModule,h,p]]}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(x,[{type:e.NgModule,args:[{declarations:[b],exports:[b],imports:[r.CommonModule,h,p]}]}],null,null)}();function R(s){const t=["r","g","b","a","h","s","l","v"];let n=0,i=0;return t.forEach(o=>{!s[o]||(n+=1,isNaN(s[o])||(i+=1),(o==="s"||o==="l")&&/^\d+%$/.test(s[o])&&(i+=1))}),n===i?s:!1}function F(s,t,n){const i=s.hex?new L.C(s.hex):new L.C(s);n&&i.setAlpha(1);const o=i.toHsl(),l=i.toHsv(),d=i.toRgb(),a=i.toHex();o.s===0&&(o.h=t||0,l.h=t||0);const c=a==="000000"&&d.a===0;return{hsl:o,hex:c?"transparent":i.toHexString(),rgb:d,hsv:l,oldHue:s.h||t||o.h,source:s.source}}function K(s){return new L.C(s).isValid}function Y(s){if(!s)return"#fff";const t=F(s);return t.hex==="transparent"?"rgba(0,0,0,0.4)":(t.rgb.r*299+t.rgb.g*587+t.rgb.b*114)/1e3>=128?"#000":"#fff"}var C;(function(s){s.HEX="hex",s.HSL="hsl",s.HSV="hsv",s.RGB="rgb"})(C||(C={}));class f{constructor(){this.mode=C.HEX,this.color={h:250,s:.5,l:.2,a:1},this.colorChange=new e.EventEmitter,this.onChange=new e.EventEmitter,this.onChangeComplete=new e.EventEmitter,this.onSwatchHover=new e.EventEmitter,this._onChangeCompleteSubscription=new N.Subscription,this._onSwatchHoverSubscription=new N.Subscription}ngOnInit(){this.changes=this.onChange.pipe((0,T.debounceTime)(100),(0,T.tap)(t=>{switch(this.onChangeComplete.emit(t),this.mode){case C.HEX:this.colorChange.emit(t.color.hex);break;case C.HSL:this.colorChange.emit(t.color.hsl);break;case C.HSV:this.colorChange.emit(t.color.hsv);break;case C.RGB:this.colorChange.emit(t.color.rgb);break;default:const n=`The mode '${this.mode}' is not supported`;if((0,e.isDevMode)())throw new Error(n);console.warn(n);break}})).subscribe(),this.setState(F(this.color,0)),this.currentColor=this.hex}ngOnChanges(){this.setState(F(this.color,this.oldHue))}ngOnDestroy(){this.changes?.unsubscribe(),this._onChangeCompleteSubscription.unsubscribe(),this._onSwatchHoverSubscription.unsubscribe()}setState(t){this.oldHue=t.oldHue,this.hsl=t.hsl,this.hsv=t.hsv,this.rgb=t.rgb,this.hex=t.hex,this.source=t.source,this.afterValidChange()}handleChange(t,n){if(R(t)){const o=F(t,t.h||this.oldHue,this.disableAlpha);this.setState(o),this.onChange.emit({color:o,$event:n}),this.afterValidChange()}}afterValidChange(){}handleSwatchHover(t,n){if(R(t)){const o=F(t,t.h||this.oldHue);this.setState(o),this.onSwatchHover.emit({color:o,$event:n})}}registerOnChange(t){this._onChangeCompleteSubscription.add(this.onChangeComplete.pipe((0,T.tap)(n=>t(n.color.hex))).subscribe())}registerOnTouched(t){this._onSwatchHoverSubscription.add(this.onSwatchHover.pipe((0,T.tap)(()=>t())).subscribe())}setDisabledState(t){}writeValue(t){this.color=t}}f.\u0275fac=function(t){return new(t||f)},f.\u0275cmp=e.\u0275\u0275defineComponent({type:f,selectors:[["color-wrap"]],inputs:{className:"className",mode:"mode",color:"color"},outputs:{colorChange:"colorChange",onChange:"onChange",onChangeComplete:"onChangeComplete",onSwatchHover:"onSwatchHover"},features:[e.\u0275\u0275ProvidersFeature([{provide:$.NG_VALUE_ACCESSOR,useExisting:(0,e.forwardRef)(()=>f),multi:!0}]),e.\u0275\u0275NgOnChangesFeature],decls:0,vars:0,template:function(t,n){},encapsulation:2}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(f,[{type:e.Component,args:[{selector:"color-wrap",template:"",providers:[{provide:$.NG_VALUE_ACCESSOR,useExisting:(0,e.forwardRef)(()=>f),multi:!0}]}]}],null,{className:[{type:e.Input}],mode:[{type:e.Input}],color:[{type:e.Input}],colorChange:[{type:e.Output}],onChange:[{type:e.Output}],onChangeComplete:[{type:e.Output}],onSwatchHover:[{type:e.Output}]})}();class D{}D.\u0275fac=function(t){return new(t||D)},D.\u0275mod=e.\u0275\u0275defineNgModule({type:D}),D.\u0275inj=e.\u0275\u0275defineInjector({imports:[[r.CommonModule]]}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(D,[{type:e.NgModule,args:[{declarations:[f],exports:[f],imports:[r.CommonModule]}]}],null,null)}();let G=0;class y{constructor(){this.placeholder="",this.onChange=new e.EventEmitter,this.focus=!1,this.uniqueId=`editableInput-${++G}`}ngOnInit(){this.wrapStyle=this.style&&this.style.wrap?this.style.wrap:{},this.inputStyle=this.style&&this.style.input?this.style.input:{},this.labelStyle=this.style&&this.style.label?this.style.label:{},this.dragLabel&&(this.labelStyle.cursor="ew-resize")}handleFocus(t){this.focus=!0}handleFocusOut(t){this.focus=!1,this.currentValue=this.blurValue}handleKeydown(t){const n=String(t.target.value),i=n.indexOf("%")>-1,o=Number(n.replace(/%/g,""));if(isNaN(o))return;const l=this.arrowOffset||1;t.keyCode===38&&(this.label?this.onChange.emit({data:{[this.label]:o+l},$event:t}):this.onChange.emit({data:o+l,$event:t}),i?this.currentValue=`${o+l}%`:this.currentValue=o+l),t.keyCode===40&&(this.label?this.onChange.emit({data:{[this.label]:o-l},$event:t}):this.onChange.emit({data:o-l,$event:t}),i?this.currentValue=`${o-l}%`:this.currentValue=o-l)}handleKeyup(t){t.keyCode===40||t.keyCode===38||`${this.currentValue}`!==t.target.value&&(this.label?this.onChange.emit({data:{[this.label]:t.target.value},$event:t}):this.onChange.emit({data:t.target.value,$event:t}))}ngOnChanges(){this.focus?this.blurValue=String(this.value).toUpperCase():(this.currentValue=String(this.value).toUpperCase(),this.blurValue=String(this.value).toUpperCase())}ngOnDestroy(){this.unsubscribe()}subscribe(){this.mousemove=(0,N.fromEvent)(document,"mousemove").subscribe(t=>this.handleDrag(t)),this.mouseup=(0,N.fromEvent)(document,"mouseup").subscribe(()=>this.unsubscribe())}unsubscribe(){this.mousemove&&this.mousemove.unsubscribe(),this.mouseup&&this.mouseup.unsubscribe()}handleMousedown(t){this.dragLabel&&(t.preventDefault(),this.handleDrag(t),this.subscribe())}handleDrag(t){if(this.dragLabel){const n=Math.round(this.value+t.movementX);n>=0&&n<=this.dragMax&&this.onChange.emit({data:{[this.label]:n},$event:t})}}}y.\u0275fac=function(t){return new(t||y)},y.\u0275cmp=e.\u0275\u0275defineComponent({type:y,selectors:[["color-editable-input"]],inputs:{style:"style",label:"label",value:"value",arrowOffset:"arrowOffset",dragLabel:"dragLabel",dragMax:"dragMax",placeholder:"placeholder"},outputs:{onChange:"onChange"},features:[e.\u0275\u0275NgOnChangesFeature],decls:3,vars:6,consts:[[1,"wrap",3,"ngStyle"],["spellCheck","false",3,"ngStyle","value","placeholder","keydown","keyup","focus","focusout"],[3,"id","ngStyle","mousedown",4,"ngIf"],[3,"id","ngStyle","mousedown"]],template:function(t,n){t&1&&(e.\u0275\u0275elementStart(0,"div",0)(1,"input",1),e.\u0275\u0275listener("keydown",function(o){return n.handleKeydown(o)})("keyup",function(o){return n.handleKeyup(o)})("focus",function(o){return n.handleFocus(o)})("focusout",function(o){return n.handleFocusOut(o)}),e.\u0275\u0275elementEnd(),e.\u0275\u0275template(2,B,2,3,"span",2),e.\u0275\u0275elementEnd()),t&2&&(e.\u0275\u0275property("ngStyle",n.wrapStyle),e.\u0275\u0275advance(1),e.\u0275\u0275property("ngStyle",n.inputStyle)("value",n.currentValue)("placeholder",n.placeholder),e.\u0275\u0275attribute("aria-labelledby",n.uniqueId),e.\u0275\u0275advance(1),e.\u0275\u0275property("ngIf",n.label))},dependencies:[r.NgStyle,r.NgIf],styles:["[_nghost-%COMP%]{display:flex}.wrap[_ngcontent-%COMP%]{position:relative}"],changeDetection:0}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(y,[{type:e.Component,args:[{selector:"color-editable-input",template:`
    <div class="wrap" [ngStyle]="wrapStyle">
      <input
        [ngStyle]="inputStyle"
        spellCheck="false"
        [value]="currentValue"
        [placeholder]="placeholder"
        (keydown)="handleKeydown($event)"
        (keyup)="handleKeyup($event)"
        (focus)="handleFocus($event)"
        (focusout)="handleFocusOut($event)"
        [attr.aria-labelledby]="uniqueId"
      />
      <span [id]="uniqueId" *ngIf="label" [ngStyle]="labelStyle" (mousedown)="handleMousedown($event)">
        {{ label }}
      </span>
    </div>
  `,styles:[`
      :host {
        display: flex;
      }
      .wrap {
        position: relative;
      }
    `],changeDetection:e.ChangeDetectionStrategy.OnPush}]}],null,{style:[{type:e.Input}],label:[{type:e.Input}],value:[{type:e.Input}],arrowOffset:[{type:e.Input}],dragLabel:[{type:e.Input}],dragMax:[{type:e.Input}],placeholder:[{type:e.Input}],onChange:[{type:e.Output}]})}();class k{}k.\u0275fac=function(t){return new(t||k)},k.\u0275mod=e.\u0275\u0275defineNgModule({type:k}),k.\u0275inj=e.\u0275\u0275defineInjector({imports:[[r.CommonModule]]}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(k,[{type:e.NgModule,args:[{declarations:[y],exports:[y],imports:[r.CommonModule]}]}],null,null)}();class v{constructor(){this.hidePointer=!1,this.direction="horizontal",this.onChange=new e.EventEmitter,this.left="0px",this.top=""}ngOnChanges(){this.direction==="horizontal"?this.left=`${this.hsl.h*100/360}%`:this.top=`${-(this.hsl.h*100/360)+100}%`}handleChange({top:t,left:n,containerHeight:i,containerWidth:o,$event:l}){let d;if(this.direction==="vertical"){let a;if(t<0)a=359;else if(t>i)a=0;else{const c=-(t*100/i)+100;a=360*c/100}this.hsl.h!==a&&(d={h:a,s:this.hsl.s,l:this.hsl.l,a:this.hsl.a,source:"rgb"})}else{let a;if(n<0)a=0;else if(n>o)a=359;else{const c=n*100/o;a=360*c/100}this.hsl.h!==a&&(d={h:a,s:this.hsl.s,l:this.hsl.l,a:this.hsl.a,source:"rgb"})}!d||this.onChange.emit({data:d,$event:l})}}v.\u0275fac=function(t){return new(t||v)},v.\u0275cmp=e.\u0275\u0275defineComponent({type:v,selectors:[["color-hue"]],inputs:{hsl:"hsl",pointer:"pointer",radius:"radius",shadow:"shadow",hidePointer:"hidePointer",direction:"direction"},outputs:{onChange:"onChange"},features:[e.\u0275\u0275NgOnChangesFeature],decls:3,vars:8,consts:[["ngx-color-coordinates","",1,"color-hue-container",3,"coordinatesChange"],["class","color-hue-pointer",3,"left","top",4,"ngIf"],[1,"color-hue-pointer"],[1,"color-hue-slider",3,"ngStyle"]],template:function(t,n){t&1&&(e.\u0275\u0275elementStart(0,"div")(1,"div",0),e.\u0275\u0275listener("coordinatesChange",function(o){return n.handleChange(o)}),e.\u0275\u0275template(2,X,2,5,"div",1),e.\u0275\u0275elementEnd()()),t&2&&(e.\u0275\u0275classMapInterpolate1("color-hue color-hue-",n.direction,""),e.\u0275\u0275styleProp("border-radius",n.radius,"px")("box-shadow",n.shadow),e.\u0275\u0275advance(2),e.\u0275\u0275property("ngIf",!n.hidePointer))},dependencies:[u,r.NgIf,r.NgStyle],styles:[".color-hue[_ngcontent-%COMP%]{position:absolute;top:0;bottom:0;left:0;right:0}.color-hue-container[_ngcontent-%COMP%]{margin:0 2px;position:relative;height:100%}.color-hue-pointer[_ngcontent-%COMP%]{position:absolute}.color-hue-slider[_ngcontent-%COMP%]{margin-top:1px;width:4px;border-radius:1px;height:8px;box-shadow:0 0 2px #0009;background:#fff;transform:translate(-2px)}.color-hue-horizontal[_ngcontent-%COMP%]{background:linear-gradient(to right,#f00 0%,#ff0 17%,#0f0 33%,#0ff 50%,#00f 67%,#f0f 83%,#f00 100%)}.color-hue-vertical[_ngcontent-%COMP%]{background:linear-gradient(to top,#f00 0%,#ff0 17%,#0f0 33%,#0ff 50%,#00f 67%,#f0f 83%,#f00 100%)}"],changeDetection:0}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(v,[{type:e.Component,args:[{selector:"color-hue",template:`
  <div class="color-hue color-hue-{{direction}}" [style.border-radius.px]="radius" [style.box-shadow]="shadow">
    <div ngx-color-coordinates (coordinatesChange)="handleChange($event)" class="color-hue-container">
      <div class="color-hue-pointer" [style.left]="left" [style.top]="top" *ngIf="!hidePointer">
        <div class="color-hue-slider" [ngStyle]="pointer"></div>
      </div>
    </div>
  </div>
  `,styles:[`
    .color-hue {
      position: absolute;
      top: 0;
      bottom: 0;
      left: 0;
      right: 0;
    }
    .color-hue-container {
      margin: 0 2px;
      position: relative;
      height: 100%;
    }
    .color-hue-pointer {
      position: absolute;
    }
    .color-hue-slider {
      margin-top: 1px;
      width: 4px;
      border-radius: 1px;
      height: 8px;
      box-shadow: 0 0 2px rgba(0, 0, 0, .6);
      background: #fff;
      transform: translateX(-2px);
    }
    .color-hue-horizontal {
      background: linear-gradient(to right, #f00 0%, #ff0 17%, #0f0
        33%, #0ff 50%, #00f 67%, #f0f 83%, #f00 100%);
    }
    .color-hue-vertical {
      background: linear-gradient(to top, #f00 0%, #ff0 17%, #0f0 33%,
        #0ff 50%, #00f 67%, #f0f 83%, #f00 100%);
    }
  `],preserveWhitespaces:!1,changeDetection:e.ChangeDetectionStrategy.OnPush}]}],null,{hsl:[{type:e.Input}],pointer:[{type:e.Input}],radius:[{type:e.Input}],shadow:[{type:e.Input}],hidePointer:[{type:e.Input}],direction:[{type:e.Input}],onChange:[{type:e.Output}]})}();class O{}O.\u0275fac=function(t){return new(t||O)},O.\u0275mod=e.\u0275\u0275defineNgModule({type:O}),O.\u0275inj=e.\u0275\u0275defineInjector({imports:[[r.CommonModule,p]]}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(O,[{type:e.NgModule,args:[{declarations:[v],exports:[v],imports:[r.CommonModule,p]}]}],null,null)}();class w{constructor(){this.zDepth=1,this.radius=1,this.background="#fff"}}w.\u0275fac=function(t){return new(t||w)},w.\u0275cmp=e.\u0275\u0275defineComponent({type:w,selectors:[["color-raised"]],inputs:{zDepth:"zDepth",radius:"radius",background:"background"},ngContentSelectors:z,decls:4,vars:5,consts:[[1,"raised-wrap"],[1,"raised-content"]],template:function(t,n){t&1&&(e.\u0275\u0275projectionDef(),e.\u0275\u0275elementStart(0,"div",0),e.\u0275\u0275element(1,"div"),e.\u0275\u0275elementStart(2,"div",1),e.\u0275\u0275projection(3),e.\u0275\u0275elementEnd()()),t&2&&(e.\u0275\u0275advance(1),e.\u0275\u0275classMapInterpolate1("raised-bg zDepth-",n.zDepth,""),e.\u0275\u0275styleProp("background",n.background))},styles:[".raised-wrap[_ngcontent-%COMP%]{position:relative;display:inline-block}.raised-bg[_ngcontent-%COMP%]{position:absolute;top:0px;right:0px;bottom:0px;left:0px}.raised-content[_ngcontent-%COMP%]{position:relative}.zDepth-0[_ngcontent-%COMP%]{box-shadow:none}.zDepth-1[_ngcontent-%COMP%]{box-shadow:0 2px 10px #0000001f,0 2px 5px #00000029}.zDepth-2[_ngcontent-%COMP%]{box-shadow:0 6px 20px #00000030,0 8px 17px #0003}.zDepth-3[_ngcontent-%COMP%]{box-shadow:0 17px 50px #00000030,0 12px 15px #0000003d}.zDepth-4[_ngcontent-%COMP%]{box-shadow:0 25px 55px #00000036,0 16px 28px #00000038}.zDepth-5[_ngcontent-%COMP%]{box-shadow:0 40px 77px #00000038,0 27px 24px #0003}"],changeDetection:0}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(w,[{type:e.Component,args:[{selector:"color-raised",template:`
  <div class="raised-wrap">
    <div class="raised-bg zDepth-{{zDepth}}" [style.background]="background"></div>
    <div class="raised-content">
      <ng-content></ng-content>
    </div>
  </div>
  `,styles:[`
    .raised-wrap {
      position: relative;
      display: inline-block;
    }
    .raised-bg {
      position: absolute;
      top: 0px;
      right: 0px;
      bottom: 0px;
      left: 0px;
    }
    .raised-content {
      position: relative;
    }
    .zDepth-0 {
      box-shadow: none;
    }
    .zDepth-1 {
      box-shadow: 0 2px 10px rgba(0,0,0,.12), 0 2px 5px rgba(0,0,0,.16);
    }
    .zDepth-2 {
      box-shadow: 0 6px 20px rgba(0,0,0,.19), 0 8px 17px rgba(0,0,0,.2);
    }
    .zDepth-3 {
      box-shadow: 0 17px 50px rgba(0,0,0,.19), 0 12px 15px rgba(0,0,0,.24);
    }
    .zDepth-4 {
      box-shadow: 0 25px 55px rgba(0,0,0,.21), 0 16px 28px rgba(0,0,0,.22);
    }
    .zDepth-5 {
      box-shadow: 0 40px 77px rgba(0,0,0,.22), 0 27px 24px rgba(0,0,0,.2);
    }
  `],preserveWhitespaces:!1,changeDetection:e.ChangeDetectionStrategy.OnPush}]}],null,{zDepth:[{type:e.Input}],radius:[{type:e.Input}],background:[{type:e.Input}]})}();class I{}I.\u0275fac=function(t){return new(t||I)},I.\u0275mod=e.\u0275\u0275defineNgModule({type:I}),I.\u0275inj=e.\u0275\u0275defineInjector({imports:[[r.CommonModule]]}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(I,[{type:e.NgModule,args:[{declarations:[w],exports:[w],imports:[r.CommonModule]}]}],null,null)}();class _{constructor(){this.onChange=new e.EventEmitter}ngOnChanges(){this.background=`hsl(${this.hsl.h}, 100%, 50%)`,this.pointerTop=-(this.hsv.v*100)+1+100+"%",this.pointerLeft=this.hsv.s*100+"%"}handleChange({top:t,left:n,containerHeight:i,containerWidth:o,$event:l}){n<0?n=0:n>o?n=o:t<0?t=0:t>i&&(t=i);const d=n/o;let a=-(t/i)+1;a=a>0?a:0,a=a>1?1:a;const c={h:this.hsl.h,s:d,v:a,a:this.hsl.a,source:"hsva"};this.onChange.emit({data:c,$event:l})}}_.\u0275fac=function(t){return new(t||_)},_.\u0275cmp=e.\u0275\u0275defineComponent({type:_,selectors:[["color-saturation"]],inputs:{hsl:"hsl",hsv:"hsv",radius:"radius",pointer:"pointer",circle:"circle"},outputs:{onChange:"onChange"},features:[e.\u0275\u0275NgOnChangesFeature],decls:5,vars:8,consts:[["ngx-color-coordinates","",1,"color-saturation",3,"coordinatesChange"],[1,"saturation-white"],[1,"saturation-black"],[1,"saturation-pointer",3,"ngStyle"],[1,"saturation-circle",3,"ngStyle"]],template:function(t,n){t&1&&(e.\u0275\u0275elementStart(0,"div",0),e.\u0275\u0275listener("coordinatesChange",function(o){return n.handleChange(o)}),e.\u0275\u0275elementStart(1,"div",1),e.\u0275\u0275element(2,"div",2),e.\u0275\u0275elementStart(3,"div",3),e.\u0275\u0275element(4,"div",4),e.\u0275\u0275elementEnd()()()),t&2&&(e.\u0275\u0275styleProp("background",n.background),e.\u0275\u0275advance(3),e.\u0275\u0275styleProp("top",n.pointerTop)("left",n.pointerLeft),e.\u0275\u0275property("ngStyle",n.pointer),e.\u0275\u0275advance(1),e.\u0275\u0275property("ngStyle",n.circle))},dependencies:[u,r.NgStyle],styles:[".saturation-white[_ngcontent-%COMP%]{background:linear-gradient(to right,#fff,rgba(255,255,255,0));position:absolute;top:0;bottom:0;left:0;right:0}.saturation-black[_ngcontent-%COMP%]{background:linear-gradient(to top,#000,rgba(0,0,0,0));position:absolute;top:0;bottom:0;left:0;right:0}.color-saturation[_ngcontent-%COMP%]{position:absolute;top:0;bottom:0;left:0;right:0}.saturation-pointer[_ngcontent-%COMP%]{position:absolute;cursor:default}.saturation-circle[_ngcontent-%COMP%]{width:4px;height:4px;box-shadow:0 0 0 1.5px #fff,inset 0 0 1px 1px #0000004d,0 0 1px 2px #0006;border-radius:50%;cursor:hand;transform:translate(-2px,-4px)}"],changeDetection:0}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(_,[{type:e.Component,args:[{selector:"color-saturation",template:`
  <div class="color-saturation" ngx-color-coordinates (coordinatesChange)="handleChange($event)" [style.background]="background">
    <div class="saturation-white">
      <div class="saturation-black"></div>
      <div class="saturation-pointer" [ngStyle]="pointer" [style.top]="pointerTop" [style.left]="pointerLeft">
        <div class="saturation-circle" [ngStyle]="circle"></div>
      </div>
    </div>
  </div>
  `,styles:[`
    .saturation-white {
      background: linear-gradient(to right, #fff, rgba(255,255,255,0));
      position: absolute;
      top: 0;
      bottom: 0;
      left: 0;
      right: 0;
    }
    .saturation-black {
      background: linear-gradient(to top, #000, rgba(0,0,0,0));
      position: absolute;
      top: 0;
      bottom: 0;
      left: 0;
      right: 0;
    }
    .color-saturation {
      position: absolute;
      top: 0;
      bottom: 0;
      left: 0;
      right: 0;
    }
    .saturation-pointer {
      position: absolute;
      cursor: default;
    }
    .saturation-circle {
      width: 4px;
      height: 4px;
      box-shadow: 0 0 0 1.5px #fff, inset 0 0 1px 1px rgba(0,0,0,.3), 0 0 1px 2px rgba(0,0,0,.4);
      border-radius: 50%;
      cursor: hand;
      transform: translate(-2px, -4px);
    }
  `],preserveWhitespaces:!1,changeDetection:e.ChangeDetectionStrategy.OnPush}]}],null,{hsl:[{type:e.Input}],hsv:[{type:e.Input}],radius:[{type:e.Input}],pointer:[{type:e.Input}],circle:[{type:e.Input}],onChange:[{type:e.Output}]})}();class E{}E.\u0275fac=function(t){return new(t||E)},E.\u0275mod=e.\u0275\u0275defineNgModule({type:E}),E.\u0275inj=e.\u0275\u0275defineInjector({imports:[[r.CommonModule,p]]}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(E,[{type:e.NgModule,args:[{declarations:[_],exports:[_],imports:[r.CommonModule,p]}]}],null,null)}();class M{constructor(){this.style={},this.focusStyle={},this.onClick=new e.EventEmitter,this.onHover=new e.EventEmitter,this.divStyles={},this.focusStyles={},this.inFocus=!1}ngOnInit(){this.divStyles={background:this.color,...this.style}}currentStyles(){return this.focusStyles={...this.divStyles,...this.focusStyle},this.focus||this.inFocus?this.focusStyles:this.divStyles}handleFocusOut(){this.inFocus=!1}handleFocus(){this.inFocus=!0}handleHover(t,n){this.onHover.emit({hex:t,$event:n})}handleClick(t,n){this.onClick.emit({hex:t,$event:n})}}M.\u0275fac=function(t){return new(t||M)},M.\u0275cmp=e.\u0275\u0275defineComponent({type:M,selectors:[["color-swatch"]],inputs:{color:"color",style:"style",focusStyle:"focusStyle",focus:"focus"},outputs:{onClick:"onClick",onHover:"onHover"},ngContentSelectors:z,decls:3,vars:3,consts:[["tabindex","0",1,"swatch",3,"ngStyle","click","keydown.enter","focus","blur","mouseover"],["boxShadow","inset 0 0 0 1px rgba(0,0,0,0.1)",4,"ngIf"],["boxShadow","inset 0 0 0 1px rgba(0,0,0,0.1)"]],template:function(t,n){t&1&&(e.\u0275\u0275projectionDef(),e.\u0275\u0275elementStart(0,"div",0),e.\u0275\u0275listener("click",function(o){return n.handleClick(n.color,o)})("keydown.enter",function(o){return n.handleClick(n.color,o)})("focus",function(){return n.handleFocus()})("blur",function(){return n.handleFocusOut()})("mouseover",function(o){return n.handleHover(n.color,o)}),e.\u0275\u0275projection(1),e.\u0275\u0275template(2,U,1,0,"color-checkboard",1),e.\u0275\u0275elementEnd()),t&2&&(e.\u0275\u0275property("ngStyle",n.currentStyles()),e.\u0275\u0275attribute("title",n.color),e.\u0275\u0275advance(2),e.\u0275\u0275property("ngIf",n.color==="transparent"))},dependencies:[g,r.NgStyle,r.NgIf],styles:[".swatch[_ngcontent-%COMP%]{outline:none;height:100%;width:100%;cursor:pointer;position:relative}"],changeDetection:0}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(M,[{type:e.Component,args:[{selector:"color-swatch",template:`
    <div
      class="swatch"
      [ngStyle]="currentStyles()"
      [attr.title]="color"
      (click)="handleClick(color, $event)"
      (keydown.enter)="handleClick(color, $event)"
      (focus)="handleFocus()"
      (blur)="handleFocusOut()"
      (mouseover)="handleHover(color, $event)"
      tabindex="0"
    >
      <ng-content></ng-content>
      <color-checkboard
        *ngIf="color === 'transparent'"
        boxShadow="inset 0 0 0 1px rgba(0,0,0,0.1)"
      ></color-checkboard>
    </div>
  `,styles:[`
      .swatch {
        outline: none;
        height: 100%;
        width: 100%;
        cursor: pointer;
        position: relative;
      }
    `],changeDetection:e.ChangeDetectionStrategy.OnPush}]}],null,{color:[{type:e.Input}],style:[{type:e.Input}],focusStyle:[{type:e.Input}],focus:[{type:e.Input}],onClick:[{type:e.Output}],onHover:[{type:e.Output}]})}();class P{}P.\u0275fac=function(t){return new(t||P)},P.\u0275mod=e.\u0275\u0275defineNgModule({type:P}),P.\u0275inj=e.\u0275\u0275defineInjector({imports:[[r.CommonModule,h]]}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(P,[{type:e.NgModule,args:[{declarations:[M],exports:[M],imports:[r.CommonModule,h]}]}],null,null)}();class S{constructor(){this.onChange=new e.EventEmitter}ngOnChanges(){this.gradient={background:`linear-gradient(to right,
          hsl(${this.hsl.h}, 90%, 55%),
          #000)`};const t=new L.C(this.hsl).toHsv();this.pointerLeft=100-t.v*100}handleChange({left:t,containerWidth:n,$event:i}){let o,l;t<0?l=0:t>n?l=1:l=Math.round(t*100/n)/100,new L.C(this.hsl).toHsv().v!==l&&(o={h:this.hsl.h,s:100,v:1-l,l:this.hsl.l,a:this.hsl.a,source:"rgb"}),o&&this.onChange.emit({data:o,$event:i})}}S.\u0275fac=function(t){return new(t||S)},S.\u0275cmp=e.\u0275\u0275defineComponent({type:S,selectors:[["color-shade"]],inputs:{hsl:"hsl",rgb:"rgb",pointer:"pointer",shadow:"shadow",radius:"radius"},outputs:{onChange:"onChange"},features:[e.\u0275\u0275NgOnChangesFeature],decls:5,vars:12,consts:[[1,"shade"],[1,"shade-gradient",3,"ngStyle"],["ngx-color-coordinates","",1,"shade-container",3,"coordinatesChange"],[1,"shade-pointer"],[1,"shade-slider",3,"ngStyle"]],template:function(t,n){t&1&&(e.\u0275\u0275elementStart(0,"div",0),e.\u0275\u0275element(1,"div",1),e.\u0275\u0275elementStart(2,"div",2),e.\u0275\u0275listener("coordinatesChange",function(o){return n.handleChange(o)}),e.\u0275\u0275elementStart(3,"div",3),e.\u0275\u0275element(4,"div",4),e.\u0275\u0275elementEnd()()()),t&2&&(e.\u0275\u0275styleProp("border-radius",n.radius),e.\u0275\u0275advance(1),e.\u0275\u0275styleProp("box-shadow",n.shadow)("border-radius",n.radius),e.\u0275\u0275property("ngStyle",n.gradient),e.\u0275\u0275advance(2),e.\u0275\u0275styleProp("left",n.pointerLeft,"%")("top",n.pointerTop,"%"),e.\u0275\u0275advance(1),e.\u0275\u0275property("ngStyle",n.pointer))},dependencies:[r.NgStyle,u],styles:[".shade[_ngcontent-%COMP%]{position:absolute;top:0;bottom:0;left:0;right:0}.shade-gradient[_ngcontent-%COMP%]{position:absolute;top:0;bottom:0;left:0;right:0}.shade-container[_ngcontent-%COMP%]{position:relative;height:100%;margin:0 3px}.shade-pointer[_ngcontent-%COMP%]{position:absolute}.shade-slider[_ngcontent-%COMP%]{width:4px;border-radius:1px;height:8px;box-shadow:0 0 2px #0009;background:#fff;margin-top:1px;transform:translate(-2px)}"],changeDetection:0}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(S,[{type:e.Component,args:[{selector:"color-shade",template:`
    <div class="shade" [style.border-radius]="radius">
      <div
        class="shade-gradient"
        [ngStyle]="gradient"
        [style.box-shadow]="shadow"
        [style.border-radius]="radius"
      ></div>
      <div
        ngx-color-coordinates
        (coordinatesChange)="handleChange($event)"
        class="shade-container"
      >
        <div
          class="shade-pointer"
          [style.left.%]="pointerLeft"
          [style.top.%]="pointerTop"
        >
          <div class="shade-slider" [ngStyle]="pointer"></div>
        </div>
      </div>
    </div>
  `,styles:[`
    .shade {
      position: absolute;
      top: 0;
      bottom: 0;
      left: 0;
      right: 0;
    }
    .shade-gradient {
      position: absolute;
      top: 0;
      bottom: 0;
      left: 0;
      right: 0;
    }
    .shade-container {
      position: relative;
      height: 100%;
      margin: 0 3px;
    }
    .shade-pointer {
      position: absolute;
    }
    .shade-slider {
      width: 4px;
      border-radius: 1px;
      height: 8px;
      box-shadow: 0 0 2px rgba(0, 0, 0, .6);
      background: #fff;
      margin-top: 1px;
      transform: translateX(-2px);
    }
  `],changeDetection:e.ChangeDetectionStrategy.OnPush,preserveWhitespaces:!1}]}],null,{hsl:[{type:e.Input}],rgb:[{type:e.Input}],pointer:[{type:e.Input}],shadow:[{type:e.Input}],radius:[{type:e.Input}],onChange:[{type:e.Output}]})}();class H{}H.\u0275fac=function(t){return new(t||H)},H.\u0275mod=e.\u0275\u0275defineNgModule({type:H}),H.\u0275inj=e.\u0275\u0275defineInjector({imports:[[r.CommonModule,p]]}),function(){(typeof ngDevMode>"u"||ngDevMode)&&e.\u0275setClassMetadata(H,[{type:e.NgModule,args:[{declarations:[S],exports:[S],imports:[r.CommonModule,p]}]}],null,null)}()}}]);
