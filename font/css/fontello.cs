@font-face {
  font-family: 'fontello';
  src: url('../font/fontello.eot?87773380');
  src: url('../font/fontello.eot?87773380#iefix') format('embedded-opentype'),
       url('../font/fontello.woff?87773380') format('woff'),
       url('../font/fontello.ttf?87773380') format('truetype'),
       url('../font/fontello.svg?87773380#fontello') format('svg');
  font-weight: normal;
  font-style: normal;
}
/* Chrome hack: SVG is rendered more smooth in Windozze. 100% magic, uncomment if you need it. */
/* Note, that will break hinting! In other OS-es font will be not as sharp as it could be */
/*
@media screen and (-webkit-min-device-pixel-ratio:0) {
  @font-face {
    font-family: 'fontello';
    src: url('../font/fontello.svg?87773380#fontello') format('svg');
  }
}
*/
 
 [class^="icon-"]:before, [class*=" icon-"]:before {
  font-family: "fontello";
  font-style: normal;
  font-weight: normal;
  speak: none;
 
  display: inline-block;
  text-decoration: inherit;
  width: 1em;
  margin-right: .2em;
  text-align: center;
  /* opacity: .8; */
 
  /* For safety - reset parent styles, that can break glyph codes*/
  font-variant: normal;
  text-transform: none;
     
  /* fix buttons height, for twitter bootstrap */
  line-height: 1em;
 
  /* Animation center compensation - margins should be symmetric */
  /* remove if not needed */
  margin-left: .2em;
 
  /* you can be more comfortable with increased icons size */
  /* font-size: 120%; */
 
  /* Uncomment for 3D effect */
  /* text-shadow: 1px 1px 1px rgba(127, 127, 127, 0.3); */
}
 
.icon-mail:before { content: '\e806'; } /* '' */
.icon-cancel:before { content: '\e80f'; } /* '' */
.icon-paper-plane:before { content: '\e804'; } /* '' */
.icon-doc-text:before { content: '\e803'; } /* '' */
.icon-github-circled:before { content: '\e80e'; } /* '' */
.icon-twitter-circled:before { content: '\e808'; } /* '' */
.icon-facebook-circled:before { content: '\e807'; } /* '' */
.icon-gplus-circled:before { content: '\e809'; } /* '' */
.icon-pinterest-circled:before { content: '\e80a'; } /* '' */
.icon-linkedin-circled:before { content: '\e80b'; } /* '' */
.icon-dribbble-circled:before { content: '\e80c'; } /* '' */
.icon-stumbleupon-circled:before { content: '\e80d'; } /* '' */
.icon-picture:before { content: '\e802'; } /* '' */
.icon-trophy:before { content: '\e801'; } /* '' */
.icon-user:before { content: '\e800'; } /* '' */
.icon-download:before { content: '\e805'; } /* '' */