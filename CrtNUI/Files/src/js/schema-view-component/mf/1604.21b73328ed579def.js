(self.webpackChunkapp_studio_enterprise_schema_view=self.webpackChunkapp_studio_enterprise_schema_view||[]).push([[1604,5536],{51604:(_,d,c)=>{c.r(d),c.d(d,{ColorGithubModule:()=>l,GithubComponent:()=>n,GithubSwatchComponent:()=>i});var t=c(94450),a=c(77057),p=c(31134),u=c(34560);function C(r,e){if(r&1){const o=t.\u0275\u0275getCurrentView();t.\u0275\u0275elementStart(0,"color-github-swatch",3),t.\u0275\u0275listener("onClick",function(s){t.\u0275\u0275restoreView(o);const g=t.\u0275\u0275nextContext();return t.\u0275\u0275resetView(g.handleBlockChange(s))})("onSwatchHover",function(s){t.\u0275\u0275restoreView(o);const g=t.\u0275\u0275nextContext();return t.\u0275\u0275resetView(g.onSwatchHover.emit(s))}),t.\u0275\u0275elementEnd()}if(r&2){const o=e.$implicit;t.\u0275\u0275property("color",o)}}class i{constructor(){this.onClick=new t.EventEmitter,this.onSwatchHover=new t.EventEmitter,this.focusStyle={position:"relative","z-index":"2",outline:"2px solid #fff","box-shadow":"0 0 5px 2px rgba(0,0,0,0.25)"}}handleClick({hex:e,$event:o}){this.onClick.emit({hex:e,$event:o})}}i.\u0275fac=function(e){return new(e||i)},i.\u0275cmp=t.\u0275\u0275defineComponent({type:i,selectors:[["color-github-swatch"]],inputs:{color:"color"},outputs:{onClick:"onClick",onSwatchHover:"onSwatchHover"},decls:3,vars:2,consts:[[1,"github-swatch"],[1,"swatch",3,"color","focusStyle","onClick","onHover"],[1,"clear"]],template:function(e,o){e&1&&(t.\u0275\u0275elementStart(0,"div",0)(1,"color-swatch",1),t.\u0275\u0275listener("onClick",function(s){return o.handleClick(s)})("onHover",function(s){return o.onSwatchHover.emit(s)}),t.\u0275\u0275elementEnd(),t.\u0275\u0275element(2,"div",2),t.\u0275\u0275elementEnd()),e&2&&(t.\u0275\u0275advance(1),t.\u0275\u0275property("color",o.color)("focusStyle",o.focusStyle))},dependencies:[a.SwatchComponent],styles:[".github-swatch[_ngcontent-%COMP%]{width:25px;height:25px;font-size:0}"],changeDetection:0}),function(){(typeof ngDevMode>"u"||ngDevMode)&&t.\u0275setClassMetadata(i,[{type:t.Component,args:[{selector:"color-github-swatch",template:`
    <div class="github-swatch">
      <color-swatch
        [color]="color"
        [focusStyle]="focusStyle"
        (onClick)="handleClick($event)"
        (onHover)="onSwatchHover.emit($event)"
        class="swatch"
      ></color-swatch>
      <div class="clear"></div>
    </div>
  `,styles:[`
      .github-swatch {
        width: 25px;
        height: 25px;
        font-size: 0;
      }
    `],changeDetection:t.ChangeDetectionStrategy.OnPush,preserveWhitespaces:!1}]}],null,{color:[{type:t.Input}],onClick:[{type:t.Output}],onSwatchHover:[{type:t.Output}]})}();class n extends a.ColorWrap{constructor(){super(),this.width=212,this.colors=["#B80000","#DB3E00","#FCCB00","#008B02","#006B76","#1273DE","#004DCF","#5300EB","#EB9694","#FAD0C3","#FEF3BD","#C1E1C5","#BEDADC","#C4DEF6","#BED3F3","#D4C4FB"],this.triangle="top-left"}handleBlockChange({hex:e,$event:o}){(0,a.isValidHex)(e)&&this.handleChange({hex:e,source:"hex"},o)}handleValueChange({data:e,$event:o}){this.handleChange(e,o)}}n.\u0275fac=function(e){return new(e||n)},n.\u0275cmp=t.\u0275\u0275defineComponent({type:n,selectors:[["color-github"]],inputs:{width:"width",colors:"colors",triangle:"triangle"},features:[t.\u0275\u0275ProvidersFeature([{provide:u.NG_VALUE_ACCESSOR,useExisting:(0,t.forwardRef)(()=>n),multi:!0},{provide:a.ColorWrap,useExisting:(0,t.forwardRef)(()=>n)}]),t.\u0275\u0275InheritDefinitionFeature],decls:4,vars:7,consts:[[1,"triangleShadow"],[1,"triangle"],[3,"color","onClick","onSwatchHover",4,"ngFor","ngForOf"],[3,"color","onClick","onSwatchHover"]],template:function(e,o){e&1&&(t.\u0275\u0275elementStart(0,"div"),t.\u0275\u0275element(1,"div",0)(2,"div",1),t.\u0275\u0275template(3,C,1,1,"color-github-swatch",2),t.\u0275\u0275elementEnd()),e&2&&(t.\u0275\u0275classMapInterpolate2("github-picker ",o.triangle,"-triangle ",o.className,""),t.\u0275\u0275styleProp("width",o.width,"px"),t.\u0275\u0275advance(3),t.\u0275\u0275property("ngForOf",o.colors))},dependencies:function(){return[i,p.NgForOf]},styles:[".github-picker[_ngcontent-%COMP%]{background:rgb(255,255,255);border:1px solid rgba(0,0,0,.2);box-shadow:#00000026 0 3px 12px;border-radius:4px;position:relative;padding:5px;display:flex;flex-wrap:wrap;box-sizing:border-box}.triangleShadow[_ngcontent-%COMP%]{position:absolute;border-width:8px;border-style:solid;border-color:transparent transparent rgba(0,0,0,.15);border-image:initial}.triangle[_ngcontent-%COMP%]{position:absolute;border-width:7px;border-style:solid;border-color:transparent transparent rgb(255,255,255);border-image:initial}.hide-triangle[_ngcontent-%COMP%] > .triangle[_ngcontent-%COMP%]{display:none}.hide-triangle[_ngcontent-%COMP%] > .triangleShadow[_ngcontent-%COMP%]{display:none}.top-left-triangle[_ngcontent-%COMP%] > .triangle[_ngcontent-%COMP%]{top:-14px;left:10px}.top-left-triangle[_ngcontent-%COMP%] > .triangleShadow[_ngcontent-%COMP%]{top:-16px;left:9px}.top-right-triangle[_ngcontent-%COMP%] > .triangle[_ngcontent-%COMP%]{top:-14px;right:10px}.top-right-triangle[_ngcontent-%COMP%] > .triangleShadow[_ngcontent-%COMP%]{top:-16px;right:9px}.bottom-right-triangle[_ngcontent-%COMP%] > .triangle[_ngcontent-%COMP%]{top:35px;right:10px;transform:rotate(180deg)}.bottom-right-triangle[_ngcontent-%COMP%] > .triangleShadow[_ngcontent-%COMP%]{top:37px;right:9px;transform:rotate(180deg)}"],changeDetection:0}),function(){(typeof ngDevMode>"u"||ngDevMode)&&t.\u0275setClassMetadata(n,[{type:t.Component,args:[{selector:"color-github",template:`
  <div class="github-picker {{ triangle }}-triangle {{ className }}"
    [style.width.px]="width"
  >
    <div class="triangleShadow"></div>
    <div class="triangle"></div>
    <color-github-swatch *ngFor="let color of colors"
      [color]="color"
      (onClick)="handleBlockChange($event)"
      (onSwatchHover)="onSwatchHover.emit($event)"
    ></color-github-swatch>
  </div>
  `,styles:[`
  .github-picker {
    background: rgb(255, 255, 255);
    border: 1px solid rgba(0, 0, 0, 0.2);
    box-shadow: rgba(0, 0, 0, 0.15) 0px 3px 12px;
    border-radius: 4px;
    position: relative;
    padding: 5px;
    display: flex;
    flex-wrap: wrap;
    box-sizing: border-box;
  }
  .triangleShadow {
    position: absolute;
    border-width: 8px;
    border-style: solid;
    border-color: transparent transparent rgba(0, 0, 0, 0.15);
    border-image: initial;
  }
  .triangle {
    position: absolute;
    border-width: 7px;
    border-style: solid;
    border-color: transparent transparent rgb(255, 255, 255);
    border-image: initial;
  }
  .hide-triangle > .triangle {
    display: none;
  }
  .hide-triangle > .triangleShadow {
    display: none;
  }
  .top-left-triangle > .triangle {
    top: -14px;
    left: 10px;
  }
  .top-left-triangle > .triangleShadow {
    top: -16px;
    left: 9px;
  }
  .top-right-triangle > .triangle {
    top: -14px;
    right: 10px;
  }
  .top-right-triangle > .triangleShadow {
    top: -16px;
    right: 9px;
  }
  .bottom-right-triangle > .triangle {
    top: 35px;
    right: 10px;
    transform: rotate(180deg);
  }
  .bottom-right-triangle > .triangleShadow {
    top: 37px;
    right: 9px;
    transform: rotate(180deg);
  }
  `],changeDetection:t.ChangeDetectionStrategy.OnPush,preserveWhitespaces:!1,providers:[{provide:u.NG_VALUE_ACCESSOR,useExisting:(0,t.forwardRef)(()=>n),multi:!0},{provide:a.ColorWrap,useExisting:(0,t.forwardRef)(()=>n)}]}]}],function(){return[]},{width:[{type:t.Input}],colors:[{type:t.Input}],triangle:[{type:t.Input}]})}();class l{}l.\u0275fac=function(e){return new(e||l)},l.\u0275mod=t.\u0275\u0275defineNgModule({type:l}),l.\u0275inj=t.\u0275\u0275defineInjector({imports:[[p.CommonModule,a.SwatchModule]]}),function(){(typeof ngDevMode>"u"||ngDevMode)&&t.\u0275setClassMetadata(l,[{type:t.NgModule,args:[{declarations:[n,i],exports:[n,i],imports:[p.CommonModule,a.SwatchModule]}]}],null,null)}()}}]);
