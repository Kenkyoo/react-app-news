/*
! tailwindcss v3.4.11 | MIT License | https://tailwindcss.com
*/

/*
1. Prevent padding and border from affecting element width. (https://github.com/mozdevs/cssremedy/issues/4)
2. Allow adding a border to an element by just adding a border-width. (https://github.com/tailwindcss/tailwindcss/pull/116)
*/

*,
::before,
::after {
  box-sizing: border-box;
  /* 1 */
  border-width: 0;
  /* 2 */
  border-style: solid;
  /* 2 */
  border-color: #e5e7eb;
  /* 2 */
}

::before,
::after {
  --tw-content: '';
}

/*
1. Use a consistent sensible line-height in all browsers.
2. Prevent adjustments of font size after orientation changes in iOS.
3. Use a more readable tab size.
4. Use the user's configured `sans` font-family by default.
5. Use the user's configured `sans` font-feature-settings by default.
6. Use the user's configured `sans` font-variation-settings by default.
7. Disable tap highlights on iOS
*/

html,
:host {
  line-height: 1.5;
  /* 1 */
  -webkit-text-size-adjust: 100%;
  /* 2 */
  -moz-tab-size: 4;
  /* 3 */
  -o-tab-size: 4;
     tab-size: 4;
  /* 3 */
  font-family: Inter var, ui-sans-serif, system-ui, sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji";
  /* 4 */
  font-feature-settings: normal;
  /* 5 */
  font-variation-settings: normal;
  /* 6 */
  -webkit-tap-highlight-color: transparent;
  /* 7 */
}

/*
1. Remove the margin in all browsers.
2. Inherit line-height from `html` so users can set them as a class directly on the `html` element.
*/

body {
  margin: 0;
  /* 1 */
  line-height: inherit;
  /* 2 */
}

/*
1. Add the correct height in Firefox.
2. Correct the inheritance of border color in Firefox. (https://bugzilla.mozilla.org/show_bug.cgi?id=190655)
3. Ensure horizontal rules are visible by default.
*/

hr {
  height: 0;
  /* 1 */
  color: inherit;
  /* 2 */
  border-top-width: 1px;
  /* 3 */
}

/*
Add the correct text decoration in Chrome, Edge, and Safari.
*/

abbr:where([title]) {
  -webkit-text-decoration: underline dotted;
          text-decoration: underline dotted;
}

/*
Remove the default font size and weight for headings.
*/

h1,
h2,
h3,
h4,
h5,
h6 {
  font-size: inherit;
  font-weight: inherit;
}

/*
Reset links to optimize for opt-in styling instead of opt-out.
*/

a {
  color: inherit;
  text-decoration: inherit;
}

/*
Add the correct font weight in Edge and Safari.
*/

b,
strong {
  font-weight: bolder;
}

/*
1. Use the user's configured `mono` font-family by default.
2. Use the user's configured `mono` font-feature-settings by default.
3. Use the user's configured `mono` font-variation-settings by default.
4. Correct the odd `em` font sizing in all browsers.
*/

code,
kbd,
samp,
pre {
  font-family: ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace;
  /* 1 */
  font-feature-settings: normal;
  /* 2 */
  font-variation-settings: normal;
  /* 3 */
  font-size: 1em;
  /* 4 */
}

/*
Add the correct font size in all browsers.
*/

small {
  font-size: 80%;
}

/*
Prevent `sub` and `sup` elements from affecting the line height in all browsers.
*/

sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sub {
  bottom: -0.25em;
}

sup {
  top: -0.5em;
}

/*
1. Remove text indentation from table contents in Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=999088, https://bugs.webkit.org/show_bug.cgi?id=201297)
2. Correct table border color inheritance in all Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=935729, https://bugs.webkit.org/show_bug.cgi?id=195016)
3. Remove gaps between table borders by default.
*/

table {
  text-indent: 0;
  /* 1 */
  border-color: inherit;
  /* 2 */
  border-collapse: collapse;
  /* 3 */
}

/*
1. Change the font styles in all browsers.
2. Remove the margin in Firefox and Safari.
3. Remove default padding in all browsers.
*/

button,
input,
optgroup,
select,
textarea {
  font-family: inherit;
  /* 1 */
  font-feature-settings: inherit;
  /* 1 */
  font-variation-settings: inherit;
  /* 1 */
  font-size: 100%;
  /* 1 */
  font-weight: inherit;
  /* 1 */
  line-height: inherit;
  /* 1 */
  letter-spacing: inherit;
  /* 1 */
  color: inherit;
  /* 1 */
  margin: 0;
  /* 2 */
  padding: 0;
  /* 3 */
}

/*
Remove the inheritance of text transform in Edge and Firefox.
*/

button,
select {
  text-transform: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Remove default button styles.
*/

button,
input:where([type='button']),
input:where([type='reset']),
input:where([type='submit']) {
  -webkit-appearance: button;
  /* 1 */
  background-color: transparent;
  /* 2 */
  background-image: none;
  /* 2 */
}

/*
Use the modern Firefox focus style for all focusable elements.
*/

:-moz-focusring {
  outline: auto;
}

/*
Remove the additional `:invalid` styles in Firefox. (https://github.com/mozilla/gecko-dev/blob/2f9eacd9d3d995c937b4251a5557d95d494c9be1/layout/style/res/forms.css#L728-L737)
*/

:-moz-ui-invalid {
  box-shadow: none;
}

/*
Add the correct vertical alignment in Chrome and Firefox.
*/

progress {
  vertical-align: baseline;
}

/*
Correct the cursor style of increment and decrement buttons in Safari.
*/

::-webkit-inner-spin-button,
::-webkit-outer-spin-button {
  height: auto;
}

/*
1. Correct the odd appearance in Chrome and Safari.
2. Correct the outline style in Safari.
*/

[type='search'] {
  -webkit-appearance: textfield;
  /* 1 */
  outline-offset: -2px;
  /* 2 */
}

/*
Remove the inner padding in Chrome and Safari on macOS.
*/

::-webkit-search-decoration {
  -webkit-appearance: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Change font properties to `inherit` in Safari.
*/

::-webkit-file-upload-button {
  -webkit-appearance: button;
  /* 1 */
  font: inherit;
  /* 2 */
}

/*
Add the correct display in Chrome and Safari.
*/

summary {
  display: list-item;
}

/*
Removes the default spacing and border for appropriate elements.
*/

blockquote,
dl,
dd,
h1,
h2,
h3,
h4,
h5,
h6,
hr,
figure,
p,
pre {
  margin: 0;
}

fieldset {
  margin: 0;
  padding: 0;
}

legend {
  padding: 0;
}

ol,
ul,
menu {
  list-style: none;
  margin: 0;
  padding: 0;
}

/*
Reset default styling for dialogs.
*/

dialog {
  padding: 0;
}

/*
Prevent resizing textareas horizontally by default.
*/

textarea {
  resize: vertical;
}

/*
1. Reset the default placeholder opacity in Firefox. (https://github.com/tailwindlabs/tailwindcss/issues/3300)
2. Set the default placeholder color to the user's configured gray 400 color.
*/

input::-moz-placeholder, textarea::-moz-placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

input::placeholder,
textarea::placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

/*
Set the default cursor for buttons.
*/

button,
[role="button"] {
  cursor: pointer;
}

/*
Make sure disabled buttons don't get the pointer cursor.
*/

:disabled {
  cursor: default;
}

/*
1. Make replaced elements `display: block` by default. (https://github.com/mozdevs/cssremedy/issues/14)
2. Add `vertical-align: middle` to align replaced elements more sensibly by default. (https://github.com/jensimmons/cssremedy/issues/14#issuecomment-634934210)
   This can trigger a poorly considered lint error in some tools but is included by design.
*/

img,
svg,
video,
canvas,
audio,
iframe,
embed,
object {
  display: block;
  /* 1 */
  vertical-align: middle;
  /* 2 */
}

/*
Constrain images and videos to the parent width and preserve their intrinsic aspect ratio. (https://github.com/mozdevs/cssremedy/issues/14)
*/

img,
video {
  max-width: 100%;
  height: auto;
}

/* Make elements with the HTML hidden attribute stay hidden by default */

[hidden] {
  display: none;
}

:root,
[data-theme] {
  background-color: var(--fallback-b1,oklch(var(--b1)/1));
  color: var(--fallback-bc,oklch(var(--bc)/1));
}

@supports not (color: oklch(0% 0 0)) {
  :root {
    color-scheme: light;
    --fallback-p: #491eff;
    --fallback-pc: #d4dbff;
    --fallback-s: #ff41c7;
    --fallback-sc: #fff9fc;
    --fallback-a: #00cfbd;
    --fallback-ac: #00100d;
    --fallback-n: #2b3440;
    --fallback-nc: #d7dde4;
    --fallback-b1: #ffffff;
    --fallback-b2: #e5e6e6;
    --fallback-b3: #e5e6e6;
    --fallback-bc: #1f2937;
    --fallback-in: #00b3f0;
    --fallback-inc: #000000;
    --fallback-su: #00ca92;
    --fallback-suc: #000000;
    --fallback-wa: #ffc22d;
    --fallback-wac: #000000;
    --fallback-er: #ff6f70;
    --fallback-erc: #000000;
  }

  @media (prefers-color-scheme: dark) {
    :root {
      color-scheme: dark;
      --fallback-p: #7582ff;
      --fallback-pc: #050617;
      --fallback-s: #ff71cf;
      --fallback-sc: #190211;
      --fallback-a: #00c7b5;
      --fallback-ac: #000e0c;
      --fallback-n: #2a323c;
      --fallback-nc: #a6adbb;
      --fallback-b1: #1d232a;
      --fallback-b2: #191e24;
      --fallback-b3: #15191e;
      --fallback-bc: #a6adbb;
      --fallback-in: #00b3f0;
      --fallback-inc: #000000;
      --fallback-su: #00ca92;
      --fallback-suc: #000000;
      --fallback-wa: #ffc22d;
      --fallback-wac: #000000;
      --fallback-er: #ff6f70;
      --fallback-erc: #000000;
    }
  }
}

html {
  -webkit-tap-highlight-color: transparent;
}

* {
  scrollbar-color: color-mix(in oklch, currentColor 35%, transparent) transparent;
}

*:hover {
  scrollbar-color: color-mix(in oklch, currentColor 60%, transparent) transparent;
}

:root {
  color-scheme: light;
  --in: 72.06% 0.191 231.6;
  --su: 64.8% 0.150 160;
  --wa: 84.71% 0.199 83.87;
  --er: 71.76% 0.221 22.18;
  --pc: 89.824% 0.06192 275.75;
  --ac: 15.352% 0.0368 183.61;
  --inc: 0% 0 0;
  --suc: 0% 0 0;
  --wac: 0% 0 0;
  --erc: 0% 0 0;
  --rounded-box: 1rem;
  --rounded-btn: 0.5rem;
  --rounded-badge: 1.9rem;
  --animation-btn: 0.25s;
  --animation-input: .2s;
  --btn-focus-scale: 0.95;
  --border-btn: 1px;
  --tab-border: 1px;
  --tab-radius: 0.5rem;
  --p: 49.12% 0.3096 275.75;
  --s: 69.71% 0.329 342.55;
  --sc: 98.71% 0.0106 342.55;
  --a: 76.76% 0.184 183.61;
  --n: 32.1785% 0.02476 255.701624;
  --nc: 89.4994% 0.011585 252.096176;
  --b1: 100% 0 0;
  --b2: 96.1151% 0 0;
  --b3: 92.4169% 0.00108 197.137559;
  --bc: 27.8078% 0.029596 256.847952;
}

@media (prefers-color-scheme: dark) {
  :root {
    color-scheme: dark;
    --in: 72.06% 0.191 231.6;
    --su: 64.8% 0.150 160;
    --wa: 84.71% 0.199 83.87;
    --er: 71.76% 0.221 22.18;
    --pc: 13.138% 0.0392 275.75;
    --sc: 14.96% 0.052 342.55;
    --ac: 14.902% 0.0334 183.61;
    --inc: 0% 0 0;
    --suc: 0% 0 0;
    --wac: 0% 0 0;
    --erc: 0% 0 0;
    --rounded-box: 1rem;
    --rounded-btn: 0.5rem;
    --rounded-badge: 1.9rem;
    --animation-btn: 0.25s;
    --animation-input: .2s;
    --btn-focus-scale: 0.95;
    --border-btn: 1px;
    --tab-border: 1px;
    --tab-radius: 0.5rem;
    --p: 65.69% 0.196 275.75;
    --s: 74.8% 0.26 342.55;
    --a: 74.51% 0.167 183.61;
    --n: 31.3815% 0.021108 254.139175;
    --nc: 74.6477% 0.0216 264.435964;
    --b1: 25.3267% 0.015896 252.417568;
    --b2: 23.2607% 0.013807 253.100675;
    --b3: 21.1484% 0.01165 254.087939;
    --bc: 74.6477% 0.0216 264.435964;
  }
}

[data-theme=light] {
  color-scheme: light;
  --in: 72.06% 0.191 231.6;
  --su: 64.8% 0.150 160;
  --wa: 84.71% 0.199 83.87;
  --er: 71.76% 0.221 22.18;
  --pc: 89.824% 0.06192 275.75;
  --ac: 15.352% 0.0368 183.61;
  --inc: 0% 0 0;
  --suc: 0% 0 0;
  --wac: 0% 0 0;
  --erc: 0% 0 0;
  --rounded-box: 1rem;
  --rounded-btn: 0.5rem;
  --rounded-badge: 1.9rem;
  --animation-btn: 0.25s;
  --animation-input: .2s;
  --btn-focus-scale: 0.95;
  --border-btn: 1px;
  --tab-border: 1px;
  --tab-radius: 0.5rem;
  --p: 49.12% 0.3096 275.75;
  --s: 69.71% 0.329 342.55;
  --sc: 98.71% 0.0106 342.55;
  --a: 76.76% 0.184 183.61;
  --n: 32.1785% 0.02476 255.701624;
  --nc: 89.4994% 0.011585 252.096176;
  --b1: 100% 0 0;
  --b2: 96.1151% 0 0;
  --b3: 92.4169% 0.00108 197.137559;
  --bc: 27.8078% 0.029596 256.847952;
}

[data-theme=dark] {
  color-scheme: dark;
  --in: 72.06% 0.191 231.6;
  --su: 64.8% 0.150 160;
  --wa: 84.71% 0.199 83.87;
  --er: 71.76% 0.221 22.18;
  --pc: 13.138% 0.0392 275.75;
  --sc: 14.96% 0.052 342.55;
  --ac: 14.902% 0.0334 183.61;
  --inc: 0% 0 0;
  --suc: 0% 0 0;
  --wac: 0% 0 0;
  --erc: 0% 0 0;
  --rounded-box: 1rem;
  --rounded-btn: 0.5rem;
  --rounded-badge: 1.9rem;
  --animation-btn: 0.25s;
  --animation-input: .2s;
  --btn-focus-scale: 0.95;
  --border-btn: 1px;
  --tab-border: 1px;
  --tab-radius: 0.5rem;
  --p: 65.69% 0.196 275.75;
  --s: 74.8% 0.26 342.55;
  --a: 74.51% 0.167 183.61;
  --n: 31.3815% 0.021108 254.139175;
  --nc: 74.6477% 0.0216 264.435964;
  --b1: 25.3267% 0.015896 252.417568;
  --b2: 23.2607% 0.013807 253.100675;
  --b3: 21.1484% 0.01165 254.087939;
  --bc: 74.6477% 0.0216 264.435964;
}

[data-theme=cupcake] {
  color-scheme: light;
  --in: 72.06% 0.191 231.6;
  --su: 64.8% 0.150 160;
  --wa: 84.71% 0.199 83.87;
  --er: 71.76% 0.221 22.18;
  --pc: 15.2344% 0.017892 200.026556;
  --sc: 15.787% 0.020249 356.29965;
  --ac: 15.8762% 0.029206 78.618794;
  --nc: 84.7148% 0.013247 313.189598;
  --inc: 0% 0 0;
  --suc: 0% 0 0;
  --wac: 0% 0 0;
  --erc: 0% 0 0;
  --rounded-box: 1rem;
  --rounded-badge: 1.9rem;
  --animation-btn: 0.25s;
  --animation-input: .2s;
  --btn-focus-scale: 0.95;
  --border-btn: 1px;
  --p: 76.172% 0.089459 200.026556;
  --s: 78.9351% 0.101246 356.29965;
  --a: 79.3811% 0.146032 78.618794;
  --n: 23.5742% 0.066235 313.189598;
  --b1: 97.7882% 0.00418 56.375637;
  --b2: 93.9822% 0.007638 61.449292;
  --b3: 91.5861% 0.006811 53.440502;
  --bc: 23.5742% 0.066235 313.189598;
  --rounded-btn: 1.9rem;
  --tab-border: 2px;
  --tab-radius: 0.7rem;
}

[data-theme=coffee] {
  color-scheme: dark;
  --b2: 20.1585% 0.021457 329.708637;
  --b3: 18.6412% 0.019842 329.708637;
  --pc: 14.3993% 0.024765 62.756393;
  --sc: 86.893% 0.00597 199.19444;
  --ac: 88.5243% 0.014881 224.389184;
  --nc: 83.3022% 0.003149 326.261446;
  --inc: 15.898% 0.012774 184.558367;
  --suc: 14.9445% 0.014491 131.116276;
  --wac: 17.6301% 0.028162 87.722413;
  --erc: 15.4637% 0.025644 31.871922;
  --rounded-box: 1rem;
  --rounded-btn: 0.5rem;
  --rounded-badge: 1.9rem;
  --animation-btn: 0.25s;
  --animation-input: .2s;
  --btn-focus-scale: 0.95;
  --border-btn: 1px;
  --tab-border: 1px;
  --tab-radius: 0.5rem;
  --p: 71.9967% 0.123825 62.756393;
  --s: 34.465% 0.029849 199.19444;
  --a: 42.6213% 0.074405 224.389184;
  --n: 16.5109% 0.015743 326.261446;
  --b1: 21.6758% 0.023072 329.708637;
  --bc: 72.3547% 0.092794 79.129387;
  --in: 79.4902% 0.063869 184.558367;
  --su: 74.7224% 0.072456 131.116276;
  --wa: 88.1503% 0.140812 87.722413;
  --er: 77.3187% 0.12822 31.871922;
}

*, ::before, ::after {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-gradient-from-position:  ;
  --tw-gradient-via-position:  ;
  --tw-gradient-to-position:  ;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
  --tw-contain-size:  ;
  --tw-contain-layout:  ;
  --tw-contain-paint:  ;
  --tw-contain-style:  ;
}

::backdrop {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-gradient-from-position:  ;
  --tw-gradient-via-position:  ;
  --tw-gradient-to-position:  ;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
  --tw-contain-size:  ;
  --tw-contain-layout:  ;
  --tw-contain-paint:  ;
  --tw-contain-style:  ;
}

.artboard {
  width: 100%;
}

.avatar {
  position: relative;
  display: inline-flex;
}

.avatar > div {
  display: block;
  aspect-ratio: 1 / 1;
  overflow: hidden;
}

.avatar img {
  height: 100%;
  width: 100%;
  -o-object-fit: cover;
     object-fit: cover;
}

.avatar.placeholder > div {
  display: flex;
  align-items: center;
  justify-content: center;
}

.badge {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, -webkit-backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter, -webkit-backdrop-filter;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-timing-function: cubic-bezier(0, 0, 0.2, 1);
  transition-duration: 200ms;
  height: 1.25rem;
  font-size: 0.875rem;
  line-height: 1.25rem;
  width: -moz-fit-content;
  width: fit-content;
  padding-left: 0.563rem;
  padding-right: 0.563rem;
  border-radius: var(--rounded-badge, 1.9rem);
  border-width: 1px;
  --tw-border-opacity: 1;
  border-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-border-opacity)));
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b1,oklch(var(--b1)/var(--tw-bg-opacity)));
  --tw-text-opacity: 1;
  color: var(--fallback-bc,oklch(var(--bc)/var(--tw-text-opacity)));
}

.btm-nav {
  position: fixed;
  bottom: 0px;
  left: 0px;
  right: 0px;
  display: flex;
  width: 100%;
  flex-direction: row;
  align-items: center;
  justify-content: space-around;
  padding-bottom: env(safe-area-inset-bottom);
  height: 4rem;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b1,oklch(var(--b1)/var(--tw-bg-opacity)));
  color: currentColor;
}

.btm-nav > * {
  position: relative;
  display: flex;
  height: 100%;
  flex-basis: 100%;
  cursor: pointer;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  gap: 0.25rem;
  border-color: currentColor;
}

@media (hover:hover) {
  .label a:hover {
    --tw-text-opacity: 1;
    color: var(--fallback-bc,oklch(var(--bc)/var(--tw-text-opacity)));
  }

  .menu li > *:not(ul, .menu-title, details, .btn):active,
.menu li > *:not(ul, .menu-title, details, .btn).active,
.menu li > details > summary:active {
    --tw-bg-opacity: 1;
    background-color: var(--fallback-n,oklch(var(--n)/var(--tw-bg-opacity)));
    --tw-text-opacity: 1;
    color: var(--fallback-nc,oklch(var(--nc)/var(--tw-text-opacity)));
  }

  .tab:hover {
    --tw-text-opacity: 1;
  }

  .tabs-boxed :is(.tab-active, [aria-selected="true"]):not(.tab-disabled):not([disabled]):hover, .tabs-boxed :is(input:checked):hover {
    --tw-text-opacity: 1;
    color: var(--fallback-pc,oklch(var(--pc)/var(--tw-text-opacity)));
  }

  .table tr.hover:hover,
  .table tr.hover:nth-child(even):hover {
    --tw-bg-opacity: 1;
    background-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-bg-opacity)));
  }

  .table-zebra tr.hover:hover,
  .table-zebra tr.hover:nth-child(even):hover {
    --tw-bg-opacity: 1;
    background-color: var(--fallback-b3,oklch(var(--b3)/var(--tw-bg-opacity)));
  }
}

.btn {
  display: inline-flex;
  height: 3rem;
  min-height: 3rem;
  flex-shrink: 0;
  cursor: pointer;
  -webkit-user-select: none;
     -moz-user-select: none;
          user-select: none;
  flex-wrap: wrap;
  align-items: center;
  justify-content: center;
  border-radius: var(--rounded-btn, 0.5rem);
  border-color: transparent;
  border-color: oklch(var(--btn-color, var(--b2)) / var(--tw-border-opacity));
  padding-left: 1rem;
  padding-right: 1rem;
  text-align: center;
  font-size: 0.875rem;
  line-height: 1em;
  gap: 0.5rem;
  font-weight: 600;
  text-decoration-line: none;
  transition-duration: 200ms;
  transition-timing-function: cubic-bezier(0, 0, 0.2, 1);
  border-width: var(--border-btn, 1px);
  transition-property: color, background-color, border-color, opacity, box-shadow, transform;
  --tw-text-opacity: 1;
  color: var(--fallback-bc,oklch(var(--bc)/var(--tw-text-opacity)));
  --tw-shadow: 0 1px 2px 0 rgb(0 0 0 / 0.05);
  --tw-shadow-colored: 0 1px 2px 0 var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
  outline-color: var(--fallback-bc,oklch(var(--bc)/1));
  background-color: oklch(var(--btn-color, var(--b2)) / var(--tw-bg-opacity));
  --tw-bg-opacity: 1;
  --tw-border-opacity: 1;
}

.btn-disabled,
  .btn[disabled],
  .btn:disabled {
  pointer-events: none;
}

.btn-circle {
  height: 3rem;
  width: 3rem;
  border-radius: 9999px;
  padding: 0px;
}

:where(.btn:is(input[type="checkbox"])),
:where(.btn:is(input[type="radio"])) {
  width: auto;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
}

.btn:is(input[type="checkbox"]):after,
.btn:is(input[type="radio"]):after {
  --tw-content: attr(aria-label);
  content: var(--tw-content);
}

.card {
  position: relative;
  display: flex;
  flex-direction: column;
  border-radius: var(--rounded-box, 1rem);
}

.card:focus {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.card-body {
  display: flex;
  flex: 1 1 auto;
  flex-direction: column;
  padding: var(--padding-card, 2rem);
  gap: 0.5rem;
}

.card-body :where(p) {
  flex-grow: 1;
}

.card-actions {
  display: flex;
  flex-wrap: wrap;
  align-items: flex-start;
  gap: 0.5rem;
}

.card figure {
  display: flex;
  align-items: center;
  justify-content: center;
}

.card.image-full {
  display: grid;
}

.card.image-full:before {
  position: relative;
  content: "";
  z-index: 10;
  border-radius: var(--rounded-box, 1rem);
  --tw-bg-opacity: 1;
  background-color: var(--fallback-n,oklch(var(--n)/var(--tw-bg-opacity)));
  opacity: 0.75;
}

.card.image-full:before,
    .card.image-full > * {
  grid-column-start: 1;
  grid-row-start: 1;
}

.card.image-full > figure img {
  height: 100%;
  -o-object-fit: cover;
     object-fit: cover;
}

.card.image-full > .card-body {
  position: relative;
  z-index: 20;
  --tw-text-opacity: 1;
  color: var(--fallback-nc,oklch(var(--nc)/var(--tw-text-opacity)));
}

.checkbox {
  flex-shrink: 0;
  --chkbg: var(--fallback-bc,oklch(var(--bc)/1));
  --chkfg: var(--fallback-b1,oklch(var(--b1)/1));
  height: 1.5rem;
  width: 1.5rem;
  cursor: pointer;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  border-radius: var(--rounded-btn, 0.5rem);
  border-width: 1px;
  border-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-border-opacity)));
  --tw-border-opacity: 0.2;
}

.collapse:not(td):not(tr):not(colgroup) {
  visibility: visible;
}

.collapse {
  position: relative;
  display: grid;
  overflow: hidden;
  grid-template-rows: auto 0fr;
  transition: grid-template-rows 0.2s;
  width: 100%;
  border-radius: var(--rounded-box, 1rem);
}

.collapse-title,
.collapse > input[type="checkbox"],
.collapse > input[type="radio"],
.collapse-content {
  grid-column-start: 1;
  grid-row-start: 1;
}

.collapse > input[type="checkbox"],
.collapse > input[type="radio"] {
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  opacity: 0;
}

.collapse-content {
  visibility: hidden;
  grid-column-start: 1;
  grid-row-start: 2;
  min-height: 0px;
  transition: visibility 0.2s;
  transition: padding 0.2s ease-out,
    background-color 0.2s ease-out;
  padding-left: 1rem;
  padding-right: 1rem;
  cursor: unset;
}

.collapse[open],
.collapse-open,
.collapse:focus:not(.collapse-close) {
  grid-template-rows: auto 1fr;
}

.collapse:not(.collapse-close):has(> input[type="checkbox"]:checked),
.collapse:not(.collapse-close):has(> input[type="radio"]:checked) {
  grid-template-rows: auto 1fr;
}

.collapse[open] > .collapse-content,
.collapse-open > .collapse-content,
.collapse:focus:not(.collapse-close) > .collapse-content,
.collapse:not(.collapse-close) > input[type="checkbox"]:checked ~ .collapse-content,
.collapse:not(.collapse-close) > input[type="radio"]:checked ~ .collapse-content {
  visibility: visible;
  min-height: -moz-fit-content;
  min-height: fit-content;
}

.dropdown {
  position: relative;
  display: inline-block;
}

.dropdown > *:not(summary):focus {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.dropdown .dropdown-content {
  position: absolute;
}

.dropdown:is(:not(details)) .dropdown-content {
  visibility: hidden;
  opacity: 0;
  transform-origin: top;
  --tw-scale-x: .95;
  --tw-scale-y: .95;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, -webkit-backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter, -webkit-backdrop-filter;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-timing-function: cubic-bezier(0, 0, 0.2, 1);
  transition-duration: 200ms;
}

.dropdown-end .dropdown-content {
  inset-inline-end: 0px;
}

.dropdown-left .dropdown-content {
  bottom: auto;
  inset-inline-end: 100%;
  top: 0px;
  transform-origin: right;
}

.dropdown-right .dropdown-content {
  bottom: auto;
  inset-inline-start: 100%;
  top: 0px;
  transform-origin: left;
}

.dropdown-bottom .dropdown-content {
  bottom: auto;
  top: 100%;
  transform-origin: top;
}

.dropdown-top .dropdown-content {
  bottom: 100%;
  top: auto;
  transform-origin: bottom;
}

.dropdown-end.dropdown-right .dropdown-content {
  bottom: 0px;
  top: auto;
}

.dropdown-end.dropdown-left .dropdown-content {
  bottom: 0px;
  top: auto;
}

.dropdown.dropdown-open .dropdown-content,
.dropdown:not(.dropdown-hover):focus .dropdown-content,
.dropdown:focus-within .dropdown-content {
  visibility: visible;
  opacity: 1;
}

@media (hover: hover) {
  .dropdown.dropdown-hover:hover .dropdown-content {
    visibility: visible;
    opacity: 1;
  }

  .btm-nav > *.disabled:hover,
      .btm-nav > *[disabled]:hover {
    pointer-events: none;
    --tw-border-opacity: 0;
    background-color: var(--fallback-n,oklch(var(--n)/var(--tw-bg-opacity)));
    --tw-bg-opacity: 0.1;
    color: var(--fallback-bc,oklch(var(--bc)/var(--tw-text-opacity)));
    --tw-text-opacity: 0.2;
  }

  .btn:hover {
    --tw-border-opacity: 1;
    border-color: var(--fallback-b3,oklch(var(--b3)/var(--tw-border-opacity)));
    --tw-bg-opacity: 1;
    background-color: var(--fallback-b3,oklch(var(--b3)/var(--tw-bg-opacity)));
  }

  @supports (color: color-mix(in oklab, black, black)) {
    .btn:hover {
      background-color: color-mix(
            in oklab,
            oklch(var(--btn-color, var(--b2)) / var(--tw-bg-opacity, 1)) 90%,
            black
          );
      border-color: color-mix(
            in oklab,
            oklch(var(--btn-color, var(--b2)) / var(--tw-border-opacity, 1)) 90%,
            black
          );
    }
  }

  @supports not (color: oklch(0% 0 0)) {
    .btn:hover {
      background-color: var(--btn-color, var(--fallback-b2));
      border-color: var(--btn-color, var(--fallback-b2));
    }
  }

  .btn.glass:hover {
    --glass-opacity: 25%;
    --glass-border-opacity: 15%;
  }

  .btn-ghost:hover {
    border-color: transparent;
  }

  @supports (color: oklch(0% 0 0)) {
    .btn-ghost:hover {
      background-color: var(--fallback-bc,oklch(var(--bc)/0.2));
    }
  }

  .btn-link:hover {
    border-color: transparent;
    background-color: transparent;
    text-decoration-line: underline;
  }

  .btn-outline:hover {
    --tw-border-opacity: 1;
    border-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-border-opacity)));
    --tw-bg-opacity: 1;
    background-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-bg-opacity)));
    --tw-text-opacity: 1;
    color: var(--fallback-b1,oklch(var(--b1)/var(--tw-text-opacity)));
  }

  .btn-outline.btn-primary:hover {
    --tw-text-opacity: 1;
    color: var(--fallback-pc,oklch(var(--pc)/var(--tw-text-opacity)));
  }

  @supports (color: color-mix(in oklab, black, black)) {
    .btn-outline.btn-primary:hover {
      background-color: color-mix(in oklab, var(--fallback-p,oklch(var(--p)/1)) 90%, black);
      border-color: color-mix(in oklab, var(--fallback-p,oklch(var(--p)/1)) 90%, black);
    }
  }

  .btn-outline.btn-secondary:hover {
    --tw-text-opacity: 1;
    color: var(--fallback-sc,oklch(var(--sc)/var(--tw-text-opacity)));
  }

  @supports (color: color-mix(in oklab, black, black)) {
    .btn-outline.btn-secondary:hover {
      background-color: color-mix(in oklab, var(--fallback-s,oklch(var(--s)/1)) 90%, black);
      border-color: color-mix(in oklab, var(--fallback-s,oklch(var(--s)/1)) 90%, black);
    }
  }

  .btn-outline.btn-accent:hover {
    --tw-text-opacity: 1;
    color: var(--fallback-ac,oklch(var(--ac)/var(--tw-text-opacity)));
  }

  @supports (color: color-mix(in oklab, black, black)) {
    .btn-outline.btn-accent:hover {
      background-color: color-mix(in oklab, var(--fallback-a,oklch(var(--a)/1)) 90%, black);
      border-color: color-mix(in oklab, var(--fallback-a,oklch(var(--a)/1)) 90%, black);
    }
  }

  .btn-outline.btn-success:hover {
    --tw-text-opacity: 1;
    color: var(--fallback-suc,oklch(var(--suc)/var(--tw-text-opacity)));
  }

  @supports (color: color-mix(in oklab, black, black)) {
    .btn-outline.btn-success:hover {
      background-color: color-mix(in oklab, var(--fallback-su,oklch(var(--su)/1)) 90%, black);
      border-color: color-mix(in oklab, var(--fallback-su,oklch(var(--su)/1)) 90%, black);
    }
  }

  .btn-outline.btn-info:hover {
    --tw-text-opacity: 1;
    color: var(--fallback-inc,oklch(var(--inc)/var(--tw-text-opacity)));
  }

  @supports (color: color-mix(in oklab, black, black)) {
    .btn-outline.btn-info:hover {
      background-color: color-mix(in oklab, var(--fallback-in,oklch(var(--in)/1)) 90%, black);
      border-color: color-mix(in oklab, var(--fallback-in,oklch(var(--in)/1)) 90%, black);
    }
  }

  .btn-outline.btn-warning:hover {
    --tw-text-opacity: 1;
    color: var(--fallback-wac,oklch(var(--wac)/var(--tw-text-opacity)));
  }

  @supports (color: color-mix(in oklab, black, black)) {
    .btn-outline.btn-warning:hover {
      background-color: color-mix(in oklab, var(--fallback-wa,oklch(var(--wa)/1)) 90%, black);
      border-color: color-mix(in oklab, var(--fallback-wa,oklch(var(--wa)/1)) 90%, black);
    }
  }

  .btn-outline.btn-error:hover {
    --tw-text-opacity: 1;
    color: var(--fallback-erc,oklch(var(--erc)/var(--tw-text-opacity)));
  }

  @supports (color: color-mix(in oklab, black, black)) {
    .btn-outline.btn-error:hover {
      background-color: color-mix(in oklab, var(--fallback-er,oklch(var(--er)/1)) 90%, black);
      border-color: color-mix(in oklab, var(--fallback-er,oklch(var(--er)/1)) 90%, black);
    }
  }

  .btn-disabled:hover,
    .btn[disabled]:hover,
    .btn:disabled:hover {
    --tw-border-opacity: 0;
    background-color: var(--fallback-n,oklch(var(--n)/var(--tw-bg-opacity)));
    --tw-bg-opacity: 0.2;
    color: var(--fallback-bc,oklch(var(--bc)/var(--tw-text-opacity)));
    --tw-text-opacity: 0.2;
  }

  @supports (color: color-mix(in oklab, black, black)) {
    .btn:is(input[type="checkbox"]:checked):hover, .btn:is(input[type="radio"]:checked):hover {
      background-color: color-mix(in oklab, var(--fallback-p,oklch(var(--p)/1)) 90%, black);
      border-color: color-mix(in oklab, var(--fallback-p,oklch(var(--p)/1)) 90%, black);
    }
  }

  .dropdown.dropdown-hover:hover .dropdown-content {
    --tw-scale-x: 1;
    --tw-scale-y: 1;
    transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
  }

  :where(.menu li:not(.menu-title, .disabled) > *:not(ul, details, .menu-title)):not(.active, .btn):hover, :where(.menu li:not(.menu-title, .disabled) > details > summary:not(.menu-title)):not(.active, .btn):hover {
    cursor: pointer;
    outline: 2px solid transparent;
    outline-offset: 2px;
  }

  @supports (color: oklch(0% 0 0)) {
    :where(.menu li:not(.menu-title, .disabled) > *:not(ul, details, .menu-title)):not(.active, .btn):hover, :where(.menu li:not(.menu-title, .disabled) > details > summary:not(.menu-title)):not(.active, .btn):hover {
      background-color: var(--fallback-bc,oklch(var(--bc)/0.1));
    }
  }

  .tab[disabled],
    .tab[disabled]:hover {
    cursor: not-allowed;
    color: var(--fallback-bc,oklch(var(--bc)/var(--tw-text-opacity)));
    --tw-text-opacity: 0.2;
  }
}

.dropdown:is(details) summary::-webkit-details-marker {
  display: none;
}

.label {
  display: flex;
  -webkit-user-select: none;
     -moz-user-select: none;
          user-select: none;
  align-items: center;
  justify-content: space-between;
  padding-left: 0.25rem;
  padding-right: 0.25rem;
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
}

.input {
  flex-shrink: 1;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  height: 3rem;
  padding-left: 1rem;
  padding-right: 1rem;
  font-size: 1rem;
  line-height: 2;
  line-height: 1.5rem;
  border-radius: var(--rounded-btn, 0.5rem);
  border-width: 1px;
  border-color: transparent;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b1,oklch(var(--b1)/var(--tw-bg-opacity)));
}

.input[type="number"]::-webkit-inner-spin-button,
.input-md[type="number"]::-webkit-inner-spin-button {
  margin-top: -1rem;
  margin-bottom: -1rem;
  margin-inline-end: -1rem;
}

.join {
  display: inline-flex;
  align-items: stretch;
  border-radius: var(--rounded-btn, 0.5rem);
}

.join :where(.join-item) {
  border-start-end-radius: 0;
  border-end-end-radius: 0;
  border-end-start-radius: 0;
  border-start-start-radius: 0;
}

.join .join-item:not(:first-child):not(:last-child),
  .join *:not(:first-child):not(:last-child) .join-item {
  border-start-end-radius: 0;
  border-end-end-radius: 0;
  border-end-start-radius: 0;
  border-start-start-radius: 0;
}

.join .join-item:first-child:not(:last-child),
  .join *:first-child:not(:last-child) .join-item {
  border-start-end-radius: 0;
  border-end-end-radius: 0;
}

.join .dropdown .join-item:first-child:not(:last-child),
  .join *:first-child:not(:last-child) .dropdown .join-item {
  border-start-end-radius: inherit;
  border-end-end-radius: inherit;
}

.join :where(.join-item:first-child:not(:last-child)),
  .join :where(*:first-child:not(:last-child) .join-item) {
  border-end-start-radius: inherit;
  border-start-start-radius: inherit;
}

.join .join-item:last-child:not(:first-child),
  .join *:last-child:not(:first-child) .join-item {
  border-end-start-radius: 0;
  border-start-start-radius: 0;
}

.join :where(.join-item:last-child:not(:first-child)),
  .join :where(*:last-child:not(:first-child) .join-item) {
  border-start-end-radius: inherit;
  border-end-end-radius: inherit;
}

@supports not selector(:has(*)) {
  :where(.join *) {
    border-radius: inherit;
  }
}

@supports selector(:has(*)) {
  :where(.join *:has(.join-item)) {
    border-radius: inherit;
  }
}

.kbd {
  display: inline-flex;
  align-items: center;
  justify-content: center;
  border-radius: var(--rounded-btn, 0.5rem);
  border-width: 1px;
  border-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-border-opacity)));
  --tw-border-opacity: 0.2;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-bg-opacity)));
  padding-left: 0.5rem;
  padding-right: 0.5rem;
  border-bottom-width: 2px;
  min-height: 2.2em;
  min-width: 2.2em;
}

.link {
  cursor: pointer;
  text-decoration-line: underline;
}

.menu {
  display: flex;
  flex-direction: column;
  flex-wrap: wrap;
  font-size: 0.875rem;
  line-height: 1.25rem;
  padding: 0.5rem;
}

.menu :where(li ul) {
  position: relative;
  white-space: nowrap;
  margin-inline-start: 1rem;
  padding-inline-start: 0.5rem;
}

.menu :where(li:not(.menu-title) > *:not(ul, details, .menu-title, .btn)), .menu :where(li:not(.menu-title) > details > summary:not(.menu-title)) {
  display: grid;
  grid-auto-flow: column;
  align-content: flex-start;
  align-items: center;
  gap: 0.5rem;
  grid-auto-columns: minmax(auto, max-content) auto max-content;
  -webkit-user-select: none;
     -moz-user-select: none;
          user-select: none;
}

.menu li.disabled {
  cursor: not-allowed;
  -webkit-user-select: none;
     -moz-user-select: none;
          user-select: none;
  color: var(--fallback-bc,oklch(var(--bc)/0.3));
}

.menu :where(li > .menu-dropdown:not(.menu-dropdown-show)) {
  display: none;
}

:where(.menu li) {
  position: relative;
  display: flex;
  flex-shrink: 0;
  flex-direction: column;
  flex-wrap: wrap;
  align-items: stretch;
}

:where(.menu li) .badge {
  justify-self: end;
}

.mockup-browser {
  position: relative;
  overflow: hidden;
  overflow-x: auto;
  border-radius: var(--rounded-box, 1rem);
}

.mockup-browser pre[data-prefix]:before {
  content: attr(data-prefix);
  display: inline-block;
  text-align: right;
}

.navbar {
  display: flex;
  align-items: center;
  padding: var(--navbar-padding, 0.5rem);
  min-height: 4rem;
  width: 100%;
}

:where(.navbar > *:not(script, style)) {
  display: inline-flex;
  align-items: center;
}

.navbar-start {
  width: 50%;
  justify-content: flex-start;
}

.navbar-center {
  flex-shrink: 0;
}

.navbar-end {
  width: 50%;
  justify-content: flex-end;
}

.progress {
  position: relative;
  width: 100%;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  overflow: hidden;
  height: 0.5rem;
  border-radius: var(--rounded-box, 1rem);
  background-color: var(--fallback-bc,oklch(var(--bc)/0.2));
}

.radio {
  flex-shrink: 0;
  --chkbg: var(--bc);
  height: 1.5rem;
  width: 1.5rem;
  cursor: pointer;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  border-radius: 9999px;
  border-width: 1px;
  border-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-border-opacity)));
  --tw-border-opacity: 0.2;
}

.select {
  display: inline-flex;
  cursor: pointer;
  -webkit-user-select: none;
     -moz-user-select: none;
          user-select: none;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  height: 3rem;
  min-height: 3rem;
  padding-inline-start: 1rem;
  padding-inline-end: 2.5rem;
  font-size: 0.875rem;
  line-height: 1.25rem;
  line-height: 2;
  border-radius: var(--rounded-btn, 0.5rem);
  border-width: 1px;
  border-color: transparent;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b1,oklch(var(--b1)/var(--tw-bg-opacity)));
  background-image: linear-gradient(45deg, transparent 50%, currentColor 50%),
    linear-gradient(135deg, currentColor 50%, transparent 50%);
  background-position: calc(100% - 20px) calc(1px + 50%),
    calc(100% - 16.1px) calc(1px + 50%);
  background-size: 4px 4px,
    4px 4px;
  background-repeat: no-repeat;
}

.select[multiple] {
  height: auto;
}

.tabs-lifted:has(.tab-content[class^="rounded-"])
    .tab:first-child:not(:is(.tab-active, [aria-selected="true"])), .tabs-lifted:has(.tab-content[class*=" rounded-"])
    .tab:first-child:not(:is(.tab-active, [aria-selected="true"])) {
  border-bottom-color: transparent;
}

.tab {
  position: relative;
  grid-row-start: 1;
  display: inline-flex;
  height: 2rem;
  cursor: pointer;
  -webkit-user-select: none;
     -moz-user-select: none;
          user-select: none;
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
  flex-wrap: wrap;
  align-items: center;
  justify-content: center;
  text-align: center;
  font-size: 0.875rem;
  line-height: 1.25rem;
  line-height: 2;
  --tab-padding: 1rem;
  --tw-text-opacity: 0.5;
  --tab-color: var(--fallback-bc,oklch(var(--bc)/1));
  --tab-bg: var(--fallback-b1,oklch(var(--b1)/1));
  --tab-border-color: var(--fallback-b3,oklch(var(--b3)/1));
  color: var(--tab-color);
  padding-inline-start: var(--tab-padding, 1rem);
  padding-inline-end: var(--tab-padding, 1rem);
}

.tab:is(input[type="radio"]) {
  width: auto;
  border-bottom-right-radius: 0px;
  border-bottom-left-radius: 0px;
}

.tab:is(input[type="radio"]):after {
  --tw-content: attr(aria-label);
  content: var(--tw-content);
}

.tab:not(input):empty {
  cursor: default;
  grid-column-start: span 9999;
}

.tab-content {
  grid-column-start: 1;
  grid-column-end: span 9999;
  grid-row-start: 2;
  margin-top: calc(var(--tab-border) * -1);
  display: none;
  border-color: transparent;
  border-width: var(--tab-border, 0);
}

:checked + .tab-content:nth-child(2),
  :is(.tab-active, [aria-selected="true"]) + .tab-content:nth-child(2) {
  border-start-start-radius: 0px;
}

input.tab:checked + .tab-content,
:is(.tab-active, [aria-selected="true"]) + .tab-content {
  display: block;
}

.table {
  position: relative;
  width: 100%;
  border-radius: var(--rounded-box, 1rem);
  text-align: left;
  font-size: 0.875rem;
  line-height: 1.25rem;
}

.table :where(.table-pin-rows thead tr) {
  position: sticky;
  top: 0px;
  z-index: 1;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b1,oklch(var(--b1)/var(--tw-bg-opacity)));
}

.table :where(.table-pin-rows tfoot tr) {
  position: sticky;
  bottom: 0px;
  z-index: 1;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b1,oklch(var(--b1)/var(--tw-bg-opacity)));
}

.table :where(.table-pin-cols tr th) {
  position: sticky;
  left: 0px;
  right: 0px;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b1,oklch(var(--b1)/var(--tw-bg-opacity)));
}

.table-zebra tbody tr:nth-child(even) :where(.table-pin-cols tr th) {
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-bg-opacity)));
}

.textarea {
  min-height: 3rem;
  flex-shrink: 1;
  padding-left: 1rem;
  padding-right: 1rem;
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
  font-size: 0.875rem;
  line-height: 1.25rem;
  line-height: 2;
  border-radius: var(--rounded-btn, 0.5rem);
  border-width: 1px;
  border-color: transparent;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b1,oklch(var(--b1)/var(--tw-bg-opacity)));
}

.avatar-group {
  display: flex;
  overflow: hidden;
}

.avatar-group :where(.avatar) {
  overflow: hidden;
  border-radius: 9999px;
  border-width: 4px;
  --tw-border-opacity: 1;
  border-color: var(--fallback-b1,oklch(var(--b1)/var(--tw-border-opacity)));
}

.btm-nav > *:not(.active) {
  padding-top: 0.125rem;
}

.btm-nav > *:where(.active) {
  border-top-width: 2px;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b1,oklch(var(--b1)/var(--tw-bg-opacity)));
}

.btm-nav > *.disabled,
    .btm-nav > *[disabled] {
  pointer-events: none;
  --tw-border-opacity: 0;
  background-color: var(--fallback-n,oklch(var(--n)/var(--tw-bg-opacity)));
  --tw-bg-opacity: 0.1;
  color: var(--fallback-bc,oklch(var(--bc)/var(--tw-text-opacity)));
  --tw-text-opacity: 0.2;
}

.btm-nav > * .label {
  font-size: 1rem;
  line-height: 1.5rem;
}

@media (prefers-reduced-motion: no-preference) {
  .btn {
    animation: button-pop var(--animation-btn, 0.25s) ease-out;
  }
}

.btn:active:hover,
  .btn:active:focus {
  animation: button-pop 0s ease-out;
  transform: scale(var(--btn-focus-scale, 0.97));
}

@supports not (color: oklch(0% 0 0)) {
  .btn {
    background-color: var(--btn-color, var(--fallback-b2));
    border-color: var(--btn-color, var(--fallback-b2));
  }

  .btn-primary {
    --btn-color: var(--fallback-p);
  }

  .btn-secondary {
    --btn-color: var(--fallback-s);
  }

  .btn-accent {
    --btn-color: var(--fallback-a);
  }

  .btn-info {
    --btn-color: var(--fallback-in);
  }

  .btn-success {
    --btn-color: var(--fallback-su);
  }

  .btn-warning {
    --btn-color: var(--fallback-wa);
  }

  .btn-error {
    --btn-color: var(--fallback-er);
  }
}

@supports (color: color-mix(in oklab, black, black)) {
  .btn-active {
    background-color: color-mix(
          in oklab,
          oklch(var(--btn-color, var(--b3)) / var(--tw-bg-opacity, 1)) 90%,
          black
        );
    border-color: color-mix(
          in oklab,
          oklch(var(--btn-color, var(--b3)) / var(--tw-border-opacity, 1)) 90%,
          black
        );
  }

  .btn-outline.btn-primary.btn-active {
    background-color: color-mix(in oklab, var(--fallback-p,oklch(var(--p)/1)) 90%, black);
    border-color: color-mix(in oklab, var(--fallback-p,oklch(var(--p)/1)) 90%, black);
  }

  .btn-outline.btn-secondary.btn-active {
    background-color: color-mix(in oklab, var(--fallback-s,oklch(var(--s)/1)) 90%, black);
    border-color: color-mix(in oklab, var(--fallback-s,oklch(var(--s)/1)) 90%, black);
  }

  .btn-outline.btn-accent.btn-active {
    background-color: color-mix(in oklab, var(--fallback-a,oklch(var(--a)/1)) 90%, black);
    border-color: color-mix(in oklab, var(--fallback-a,oklch(var(--a)/1)) 90%, black);
  }

  .btn-outline.btn-success.btn-active {
    background-color: color-mix(in oklab, var(--fallback-su,oklch(var(--su)/1)) 90%, black);
    border-color: color-mix(in oklab, var(--fallback-su,oklch(var(--su)/1)) 90%, black);
  }

  .btn-outline.btn-info.btn-active {
    background-color: color-mix(in oklab, var(--fallback-in,oklch(var(--in)/1)) 90%, black);
    border-color: color-mix(in oklab, var(--fallback-in,oklch(var(--in)/1)) 90%, black);
  }

  .btn-outline.btn-warning.btn-active {
    background-color: color-mix(in oklab, var(--fallback-wa,oklch(var(--wa)/1)) 90%, black);
    border-color: color-mix(in oklab, var(--fallback-wa,oklch(var(--wa)/1)) 90%, black);
  }

  .btn-outline.btn-error.btn-active {
    background-color: color-mix(in oklab, var(--fallback-er,oklch(var(--er)/1)) 90%, black);
    border-color: color-mix(in oklab, var(--fallback-er,oklch(var(--er)/1)) 90%, black);
  }
}

.btn:focus-visible {
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
}

.btn-primary {
  --tw-text-opacity: 1;
  color: var(--fallback-pc,oklch(var(--pc)/var(--tw-text-opacity)));
  outline-color: var(--fallback-p,oklch(var(--p)/1));
}

@supports (color: oklch(0% 0 0)) {
  .btn-primary {
    --btn-color: var(--p);
  }

  .btn-secondary {
    --btn-color: var(--s);
  }

  .btn-accent {
    --btn-color: var(--a);
  }

  .btn-info {
    --btn-color: var(--in);
  }

  .btn-success {
    --btn-color: var(--su);
  }

  .btn-warning {
    --btn-color: var(--wa);
  }

  .btn-error {
    --btn-color: var(--er);
  }
}

.btn-secondary {
  --tw-text-opacity: 1;
  color: var(--fallback-sc,oklch(var(--sc)/var(--tw-text-opacity)));
  outline-color: var(--fallback-s,oklch(var(--s)/1));
}

.btn-accent {
  --tw-text-opacity: 1;
  color: var(--fallback-ac,oklch(var(--ac)/var(--tw-text-opacity)));
  outline-color: var(--fallback-a,oklch(var(--a)/1));
}

.btn-info {
  --tw-text-opacity: 1;
  color: var(--fallback-inc,oklch(var(--inc)/var(--tw-text-opacity)));
  outline-color: var(--fallback-in,oklch(var(--in)/1));
}

.btn-success {
  --tw-text-opacity: 1;
  color: var(--fallback-suc,oklch(var(--suc)/var(--tw-text-opacity)));
  outline-color: var(--fallback-su,oklch(var(--su)/1));
}

.btn-warning {
  --tw-text-opacity: 1;
  color: var(--fallback-wac,oklch(var(--wac)/var(--tw-text-opacity)));
  outline-color: var(--fallback-wa,oklch(var(--wa)/1));
}

.btn-error {
  --tw-text-opacity: 1;
  color: var(--fallback-erc,oklch(var(--erc)/var(--tw-text-opacity)));
  outline-color: var(--fallback-er,oklch(var(--er)/1));
}

.btn.glass {
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
  outline-color: currentColor;
}

.btn.glass.btn-active {
  --glass-opacity: 25%;
  --glass-border-opacity: 15%;
}

.btn-ghost {
  border-width: 1px;
  border-color: transparent;
  background-color: transparent;
  color: currentColor;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
  outline-color: currentColor;
}

.btn-ghost.btn-active {
  border-color: transparent;
  background-color: var(--fallback-bc,oklch(var(--bc)/0.2));
}

.btn-link {
  border-color: transparent;
  background-color: transparent;
  --tw-text-opacity: 1;
  color: var(--fallback-p,oklch(var(--p)/var(--tw-text-opacity)));
  text-decoration-line: underline;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
  outline-color: currentColor;
}

.btn-link.btn-active {
  border-color: transparent;
  background-color: transparent;
  text-decoration-line: underline;
}

.btn-outline {
  border-color: currentColor;
  background-color: transparent;
  --tw-text-opacity: 1;
  color: var(--fallback-bc,oklch(var(--bc)/var(--tw-text-opacity)));
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.btn-outline.btn-active {
  --tw-border-opacity: 1;
  border-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-border-opacity)));
  --tw-bg-opacity: 1;
  background-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-bg-opacity)));
  --tw-text-opacity: 1;
  color: var(--fallback-b1,oklch(var(--b1)/var(--tw-text-opacity)));
}

.btn-outline.btn-primary {
  --tw-text-opacity: 1;
  color: var(--fallback-p,oklch(var(--p)/var(--tw-text-opacity)));
}

.btn-outline.btn-primary.btn-active {
  --tw-text-opacity: 1;
  color: var(--fallback-pc,oklch(var(--pc)/var(--tw-text-opacity)));
}

.btn-outline.btn-secondary {
  --tw-text-opacity: 1;
  color: var(--fallback-s,oklch(var(--s)/var(--tw-text-opacity)));
}

.btn-outline.btn-secondary.btn-active {
  --tw-text-opacity: 1;
  color: var(--fallback-sc,oklch(var(--sc)/var(--tw-text-opacity)));
}

.btn-outline.btn-accent {
  --tw-text-opacity: 1;
  color: var(--fallback-a,oklch(var(--a)/var(--tw-text-opacity)));
}

.btn-outline.btn-accent.btn-active {
  --tw-text-opacity: 1;
  color: var(--fallback-ac,oklch(var(--ac)/var(--tw-text-opacity)));
}

.btn-outline.btn-success {
  --tw-text-opacity: 1;
  color: var(--fallback-su,oklch(var(--su)/var(--tw-text-opacity)));
}

.btn-outline.btn-success.btn-active {
  --tw-text-opacity: 1;
  color: var(--fallback-suc,oklch(var(--suc)/var(--tw-text-opacity)));
}

.btn-outline.btn-info {
  --tw-text-opacity: 1;
  color: var(--fallback-in,oklch(var(--in)/var(--tw-text-opacity)));
}

.btn-outline.btn-info.btn-active {
  --tw-text-opacity: 1;
  color: var(--fallback-inc,oklch(var(--inc)/var(--tw-text-opacity)));
}

.btn-outline.btn-warning {
  --tw-text-opacity: 1;
  color: var(--fallback-wa,oklch(var(--wa)/var(--tw-text-opacity)));
}

.btn-outline.btn-warning.btn-active {
  --tw-text-opacity: 1;
  color: var(--fallback-wac,oklch(var(--wac)/var(--tw-text-opacity)));
}

.btn-outline.btn-error {
  --tw-text-opacity: 1;
  color: var(--fallback-er,oklch(var(--er)/var(--tw-text-opacity)));
}

.btn-outline.btn-error.btn-active {
  --tw-text-opacity: 1;
  color: var(--fallback-erc,oklch(var(--erc)/var(--tw-text-opacity)));
}

.btn.btn-disabled,
  .btn[disabled],
  .btn:disabled {
  --tw-border-opacity: 0;
  background-color: var(--fallback-n,oklch(var(--n)/var(--tw-bg-opacity)));
  --tw-bg-opacity: 0.2;
  color: var(--fallback-bc,oklch(var(--bc)/var(--tw-text-opacity)));
  --tw-text-opacity: 0.2;
}

.btn:is(input[type="checkbox"]:checked),
.btn:is(input[type="radio"]:checked) {
  --tw-border-opacity: 1;
  border-color: var(--fallback-p,oklch(var(--p)/var(--tw-border-opacity)));
  --tw-bg-opacity: 1;
  background-color: var(--fallback-p,oklch(var(--p)/var(--tw-bg-opacity)));
  --tw-text-opacity: 1;
  color: var(--fallback-pc,oklch(var(--pc)/var(--tw-text-opacity)));
}

.btn:is(input[type="checkbox"]:checked):focus-visible, .btn:is(input[type="radio"]:checked):focus-visible {
  outline-color: var(--fallback-p,oklch(var(--p)/1));
}

@keyframes button-pop {
  0% {
    transform: scale(var(--btn-focus-scale, 0.98));
  }

  40% {
    transform: scale(1.02);
  }

  100% {
    transform: scale(1);
  }
}

.card :where(figure:first-child) {
  overflow: hidden;
  border-start-start-radius: inherit;
  border-start-end-radius: inherit;
  border-end-start-radius: unset;
  border-end-end-radius: unset;
}

.card :where(figure:last-child) {
  overflow: hidden;
  border-start-start-radius: unset;
  border-start-end-radius: unset;
  border-end-start-radius: inherit;
  border-end-end-radius: inherit;
}

.card:focus-visible {
  outline: 2px solid currentColor;
  outline-offset: 2px;
}

.card.bordered {
  border-width: 1px;
  --tw-border-opacity: 1;
  border-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-border-opacity)));
}

.card.compact .card-body {
  padding: 1rem;
  font-size: 0.875rem;
  line-height: 1.25rem;
}

.card-title {
  display: flex;
  align-items: center;
  gap: 0.5rem;
  font-size: 1.25rem;
  line-height: 1.75rem;
  font-weight: 600;
}

.card.image-full :where(figure) {
  overflow: hidden;
  border-radius: inherit;
}

.checkbox:focus {
  box-shadow: none;
}

.checkbox:focus-visible {
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
  outline-color: var(--fallback-bc,oklch(var(--bc)/1));
}

.checkbox:disabled {
  border-width: 0px;
  cursor: not-allowed;
  border-color: transparent;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-bg-opacity)));
  opacity: 0.2;
}

.checkbox:checked,
  .checkbox[aria-checked="true"] {
  background-repeat: no-repeat;
  animation: checkmark var(--animation-input, 0.2s) ease-out;
  background-color: var(--chkbg);
  background-image: linear-gradient(-45deg, transparent 65%, var(--chkbg) 65.99%),
      linear-gradient(45deg, transparent 75%, var(--chkbg) 75.99%),
      linear-gradient(-45deg, var(--chkbg) 40%, transparent 40.99%),
      linear-gradient(
        45deg,
        var(--chkbg) 30%,
        var(--chkfg) 30.99%,
        var(--chkfg) 40%,
        transparent 40.99%
      ),
      linear-gradient(-45deg, var(--chkfg) 50%, var(--chkbg) 50.99%);
}

.checkbox:indeterminate {
  --tw-bg-opacity: 1;
  background-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-bg-opacity)));
  background-repeat: no-repeat;
  animation: checkmark var(--animation-input, 0.2s) ease-out;
  background-image: linear-gradient(90deg, transparent 80%, var(--chkbg) 80%),
      linear-gradient(-90deg, transparent 80%, var(--chkbg) 80%),
      linear-gradient(0deg, var(--chkbg) 43%, var(--chkfg) 43%, var(--chkfg) 57%, var(--chkbg) 57%);
}

@keyframes checkmark {
  0% {
    background-position-y: 5px;
  }

  50% {
    background-position-y: -2px;
  }

  100% {
    background-position-y: 0;
  }
}

details.collapse {
  width: 100%;
}

details.collapse summary {
  position: relative;
  display: block;
  outline: 2px solid transparent;
  outline-offset: 2px;
}

details.collapse summary::-webkit-details-marker {
  display: none;
}

.collapse:focus-visible {
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
  outline-color: var(--fallback-bc,oklch(var(--bc)/1));
}

.collapse:has(.collapse-title:focus-visible),
.collapse:has(> input[type="checkbox"]:focus-visible),
.collapse:has(> input[type="radio"]:focus-visible) {
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
  outline-color: var(--fallback-bc,oklch(var(--bc)/1));
}

.collapse-arrow > .collapse-title:after {
  position: absolute;
  display: block;
  height: 0.5rem;
  width: 0.5rem;
  --tw-translate-y: -100%;
  --tw-rotate: 45deg;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
  transition-property: all;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-timing-function: cubic-bezier(0, 0, 0.2, 1);
  transition-duration: 150ms;
  transition-duration: 0.2s;
  top: 1.9rem;
  inset-inline-end: 1.4rem;
  content: "";
  transform-origin: 75% 75%;
  box-shadow: 2px 2px;
  pointer-events: none;
}

.collapse-plus > .collapse-title:after {
  position: absolute;
  display: block;
  height: 0.5rem;
  width: 0.5rem;
  transition-property: all;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-timing-function: cubic-bezier(0, 0, 0.2, 1);
  transition-duration: 300ms;
  top: 0.9rem;
  inset-inline-end: 1.4rem;
  content: "+";
  pointer-events: none;
}

.collapse:not(.collapse-open):not(.collapse-close) > input[type="checkbox"],
.collapse:not(.collapse-open):not(.collapse-close) > input[type="radio"]:not(:checked),
.collapse:not(.collapse-open):not(.collapse-close) > .collapse-title {
  cursor: pointer;
}

.collapse:focus:not(.collapse-open):not(.collapse-close):not(.collapse[open]) > .collapse-title {
  cursor: unset;
}

.collapse-title {
  position: relative;
}

:where(.collapse > input[type="checkbox"]),
:where(.collapse > input[type="radio"]) {
  z-index: 1;
}

.collapse-title,
:where(.collapse > input[type="checkbox"]),
:where(.collapse > input[type="radio"]) {
  width: 100%;
  padding: 1rem;
  padding-inline-end: 3rem;
  min-height: 3.75rem;
  transition: background-color 0.2s ease-out;
}

.collapse[open] > :where(.collapse-content),
.collapse-open > :where(.collapse-content),
.collapse:focus:not(.collapse-close) > :where(.collapse-content),
.collapse:not(.collapse-close) > :where(input[type="checkbox"]:checked ~ .collapse-content),
.collapse:not(.collapse-close) > :where(input[type="radio"]:checked ~ .collapse-content) {
  padding-bottom: 1rem;
  transition: padding 0.2s ease-out,
    background-color 0.2s ease-out;
}

.collapse[open].collapse-arrow > .collapse-title:after,
.collapse-open.collapse-arrow > .collapse-title:after,
.collapse-arrow:focus:not(.collapse-close) > .collapse-title:after,
.collapse-arrow:not(.collapse-close) > input[type="checkbox"]:checked ~ .collapse-title:after,
.collapse-arrow:not(.collapse-close) > input[type="radio"]:checked ~ .collapse-title:after {
  --tw-translate-y: -50%;
  --tw-rotate: 225deg;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.collapse[open].collapse-plus > .collapse-title:after,
.collapse-open.collapse-plus > .collapse-title:after,
.collapse-plus:focus:not(.collapse-close) > .collapse-title:after,
.collapse-plus:not(.collapse-close) > input[type="checkbox"]:checked ~ .collapse-title:after,
.collapse-plus:not(.collapse-close) > input[type="radio"]:checked ~ .collapse-title:after {
  content: "−";
}

.dropdown.dropdown-open .dropdown-content,
.dropdown:focus .dropdown-content,
.dropdown:focus-within .dropdown-content {
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.input input {
  --tw-bg-opacity: 1;
  background-color: var(--fallback-p,oklch(var(--p)/var(--tw-bg-opacity)));
  background-color: transparent;
}

.input input:focus {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.input[list]::-webkit-calendar-picker-indicator {
  line-height: 1em;
}

.input:focus,
  .input:focus-within {
  box-shadow: none;
  border-color: var(--fallback-bc,oklch(var(--bc)/0.2));
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
  outline-color: var(--fallback-bc,oklch(var(--bc)/0.2));
}

.input:has(> input[disabled]),
  .input-disabled,
  .input:disabled,
  .input[disabled] {
  cursor: not-allowed;
  --tw-border-opacity: 1;
  border-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-border-opacity)));
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-bg-opacity)));
  color: var(--fallback-bc,oklch(var(--bc)/0.4));
}

.input:has(> input[disabled])::-moz-placeholder, .input-disabled::-moz-placeholder, .input:disabled::-moz-placeholder, .input[disabled]::-moz-placeholder {
  color: var(--fallback-bc,oklch(var(--bc)/var(--tw-placeholder-opacity)));
  --tw-placeholder-opacity: 0.2;
}

.input:has(> input[disabled])::placeholder,
  .input-disabled::placeholder,
  .input:disabled::placeholder,
  .input[disabled]::placeholder {
  color: var(--fallback-bc,oklch(var(--bc)/var(--tw-placeholder-opacity)));
  --tw-placeholder-opacity: 0.2;
}

.input:has(> input[disabled]) > input[disabled] {
  cursor: not-allowed;
}

.input::-webkit-date-and-time-value {
  text-align: inherit;
}

.join > :where(*:not(:first-child)) {
  margin-top: 0px;
  margin-bottom: 0px;
  margin-inline-start: -1px;
}

.join > :where(*:not(:first-child)):is(.btn) {
  margin-inline-start: calc(var(--border-btn) * -1);
}

.join-item:focus {
  isolation: isolate;
}

.link:focus {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.link:focus-visible {
  outline: 2px solid currentColor;
  outline-offset: 2px;
}

:where(.menu li:empty) {
  --tw-bg-opacity: 1;
  background-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-bg-opacity)));
  opacity: 0.1;
  margin: 0.5rem 1rem;
  height: 1px;
}

.menu :where(li ul):before {
  position: absolute;
  bottom: 0.75rem;
  inset-inline-start: 0px;
  top: 0.75rem;
  width: 1px;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-bg-opacity)));
  opacity: 0.1;
  content: "";
}

.menu :where(li:not(.menu-title) > *:not(ul, details, .menu-title, .btn)),
.menu :where(li:not(.menu-title) > details > summary:not(.menu-title)) {
  border-radius: var(--rounded-btn, 0.5rem);
  padding-left: 1rem;
  padding-right: 1rem;
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
  text-align: start;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, -webkit-backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter, -webkit-backdrop-filter;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-timing-function: cubic-bezier(0, 0, 0.2, 1);
  transition-duration: 200ms;
  text-wrap: balance;
}

:where(.menu li:not(.menu-title, .disabled) > *:not(ul, details, .menu-title)):not(summary, .active, .btn).focus, :where(.menu li:not(.menu-title, .disabled) > *:not(ul, details, .menu-title)):not(summary, .active, .btn):focus, :where(.menu li:not(.menu-title, .disabled) > *:not(ul, details, .menu-title)):is(summary):not(.active, .btn):focus-visible, :where(.menu li:not(.menu-title, .disabled) > details > summary:not(.menu-title)):not(summary, .active, .btn).focus, :where(.menu li:not(.menu-title, .disabled) > details > summary:not(.menu-title)):not(summary, .active, .btn):focus, :where(.menu li:not(.menu-title, .disabled) > details > summary:not(.menu-title)):is(summary):not(.active, .btn):focus-visible {
  cursor: pointer;
  background-color: var(--fallback-bc,oklch(var(--bc)/0.1));
  --tw-text-opacity: 1;
  color: var(--fallback-bc,oklch(var(--bc)/var(--tw-text-opacity)));
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.menu li > *:not(ul, .menu-title, details, .btn):active,
.menu li > *:not(ul, .menu-title, details, .btn).active,
.menu li > details > summary:active {
  --tw-bg-opacity: 1;
  background-color: var(--fallback-n,oklch(var(--n)/var(--tw-bg-opacity)));
  --tw-text-opacity: 1;
  color: var(--fallback-nc,oklch(var(--nc)/var(--tw-text-opacity)));
}

.menu :where(li > details > summary)::-webkit-details-marker {
  display: none;
}

.menu :where(li > details > summary):after,
.menu :where(li > .menu-dropdown-toggle):after {
  justify-self: end;
  display: block;
  margin-top: -0.5rem;
  height: 0.5rem;
  width: 0.5rem;
  transform: rotate(45deg);
  transition-property: transform, margin-top;
  transition-duration: 0.3s;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  content: "";
  transform-origin: 75% 75%;
  box-shadow: 2px 2px;
  pointer-events: none;
}

.menu :where(li > details[open] > summary):after,
.menu :where(li > .menu-dropdown-toggle.menu-dropdown-show):after {
  transform: rotate(225deg);
  margin-top: 0;
}

.menu-title {
  padding-left: 1rem;
  padding-right: 1rem;
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
  font-size: 0.875rem;
  line-height: 1.25rem;
  font-weight: 700;
  color: var(--fallback-bc,oklch(var(--bc)/0.4));
}

.mockup-phone {
  display: inline-block;
  border: 4px solid #444;
  border-radius: 50px;
  background-color: #000;
  padding: 10px;
  margin: 0 auto;
  overflow: hidden;
}

.mockup-phone .camera {
  position: relative;
  top: 0px;
  left: 0px;
  background: #000;
  height: 25px;
  width: 150px;
  margin: 0 auto;
  border-bottom-left-radius: 17px;
  border-bottom-right-radius: 17px;
  z-index: 11;
}

.mockup-phone .camera:before {
  content: "";
  position: absolute;
  top: 35%;
  left: 50%;
  width: 50px;
  height: 4px;
  border-radius: 5px;
  background-color: #0c0b0e;
  transform: translate(-50%, -50%);
}

.mockup-phone .camera:after {
  content: "";
  position: absolute;
  top: 20%;
  left: 70%;
  width: 8px;
  height: 8px;
  border-radius: 5px;
  background-color: #0f0b25;
}

.mockup-phone .display {
  overflow: hidden;
  border-radius: 40px;
  margin-top: -25px;
}

.mockup-browser .mockup-browser-toolbar {
  margin-top: 0.75rem;
  margin-bottom: 0.75rem;
  display: inline-flex;
  width: 100%;
  align-items: center;
  padding-right: 1.4em;
}

.mockup-browser .mockup-browser-toolbar:where([dir="rtl"], [dir="rtl"] *) {
  flex-direction: row-reverse;
}

.mockup-browser .mockup-browser-toolbar:before {
  content: "";
  margin-right: 4.8rem;
  display: inline-block;
  aspect-ratio: 1 / 1;
  height: 0.75rem;
  border-radius: 9999px;
  opacity: 0.3;
  box-shadow: 1.4em 0,
          2.8em 0,
          4.2em 0;
}

.mockup-browser .mockup-browser-toolbar .input {
  position: relative;
  margin-left: auto;
  margin-right: auto;
  display: block;
  height: 1.75rem;
  width: 24rem;
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-bg-opacity)));
  padding-left: 2rem;
  direction: ltr;
}

.mockup-browser .mockup-browser-toolbar .input:before {
  content: "";
  position: absolute;
  left: 0.5rem;
  top: 50%;
  aspect-ratio: 1 / 1;
  height: 0.75rem;
  --tw-translate-y: -50%;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
  border-radius: 9999px;
  border-width: 2px;
  border-color: currentColor;
  opacity: 0.6;
}

.mockup-browser .mockup-browser-toolbar .input:after {
  content: "";
  position: absolute;
  left: 1.25rem;
  top: 50%;
  height: 0.5rem;
  --tw-translate-y: 25%;
  --tw-rotate: -45deg;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
  border-radius: 9999px;
  border-width: 1px;
  border-color: currentColor;
  opacity: 0.6;
}

@keyframes modal-pop {
  0% {
    opacity: 0;
  }
}

.progress::-moz-progress-bar {
  border-radius: var(--rounded-box, 1rem);
  --tw-bg-opacity: 1;
  background-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-bg-opacity)));
}

.progress:indeterminate {
  --progress-color: var(--fallback-bc,oklch(var(--bc)/1));
  background-image: repeating-linear-gradient(
    90deg,
    var(--progress-color) -1%,
    var(--progress-color) 10%,
    transparent 10%,
    transparent 90%
  );
  background-size: 200%;
  background-position-x: 15%;
  animation: progress-loading 5s ease-in-out infinite;
}

.progress::-webkit-progress-bar {
  border-radius: var(--rounded-box, 1rem);
  background-color: transparent;
}

.progress::-webkit-progress-value {
  border-radius: var(--rounded-box, 1rem);
  --tw-bg-opacity: 1;
  background-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-bg-opacity)));
}

.progress:indeterminate::-moz-progress-bar {
  background-color: transparent;
  background-image: repeating-linear-gradient(
    90deg,
    var(--progress-color) -1%,
    var(--progress-color) 10%,
    transparent 10%,
    transparent 90%
  );
  background-size: 200%;
  background-position-x: 15%;
  animation: progress-loading 5s ease-in-out infinite;
}

@keyframes progress-loading {
  50% {
    background-position-x: -115%;
  }
}

.radio:focus {
  box-shadow: none;
}

.radio:focus-visible {
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
  outline-color: var(--fallback-bc,oklch(var(--bc)/1));
}

.radio:checked,
  .radio[aria-checked="true"] {
  --tw-bg-opacity: 1;
  background-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-bg-opacity)));
  background-image: none;
  animation: radiomark var(--animation-input, 0.2s) ease-out;
  box-shadow: 0 0 0 4px var(--fallback-b1,oklch(var(--b1)/1)) inset,
      0 0 0 4px var(--fallback-b1,oklch(var(--b1)/1)) inset;
}

.radio:disabled {
  cursor: not-allowed;
  opacity: 0.2;
}

@keyframes radiomark {
  0% {
    box-shadow: 0 0 0 12px var(--fallback-b1,oklch(var(--b1)/1)) inset,
      0 0 0 12px var(--fallback-b1,oklch(var(--b1)/1)) inset;
  }

  50% {
    box-shadow: 0 0 0 3px var(--fallback-b1,oklch(var(--b1)/1)) inset,
      0 0 0 3px var(--fallback-b1,oklch(var(--b1)/1)) inset;
  }

  100% {
    box-shadow: 0 0 0 4px var(--fallback-b1,oklch(var(--b1)/1)) inset,
      0 0 0 4px var(--fallback-b1,oklch(var(--b1)/1)) inset;
  }
}

@keyframes rating-pop {
  0% {
    transform: translateY(-0.125em);
  }

  40% {
    transform: translateY(-0.125em);
  }

  100% {
    transform: translateY(0);
  }
}

.select:focus {
  box-shadow: none;
  border-color: var(--fallback-bc,oklch(var(--bc)/0.2));
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
  outline-color: var(--fallback-bc,oklch(var(--bc)/0.2));
}

.select-primary {
  --tw-border-opacity: 1;
  border-color: var(--fallback-p,oklch(var(--p)/var(--tw-border-opacity)));
}

.select-primary:focus {
  --tw-border-opacity: 1;
  border-color: var(--fallback-p,oklch(var(--p)/var(--tw-border-opacity)));
  outline-color: var(--fallback-p,oklch(var(--p)/1));
}

.select-disabled,
  .select:disabled,
  .select[disabled] {
  cursor: not-allowed;
  --tw-border-opacity: 1;
  border-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-border-opacity)));
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-bg-opacity)));
  color: var(--fallback-bc,oklch(var(--bc)/0.4));
}

.select-disabled::-moz-placeholder, .select:disabled::-moz-placeholder, .select[disabled]::-moz-placeholder {
  color: var(--fallback-bc,oklch(var(--bc)/var(--tw-placeholder-opacity)));
  --tw-placeholder-opacity: 0.2;
}

.select-disabled::placeholder,
  .select:disabled::placeholder,
  .select[disabled]::placeholder {
  color: var(--fallback-bc,oklch(var(--bc)/var(--tw-placeholder-opacity)));
  --tw-placeholder-opacity: 0.2;
}

.select-multiple,
  .select[multiple],
  .select[size].select:not([size="1"]) {
  background-image: none;
  padding-right: 1rem;
}

[dir="rtl"] .select {
  background-position: calc(0% + 12px) calc(1px + 50%),
    calc(0% + 16px) calc(1px + 50%);
}

.skeleton {
  border-radius: var(--rounded-box, 1rem);
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b3,oklch(var(--b3)/var(--tw-bg-opacity)));
  will-change: background-position;
  animation: skeleton 1.8s ease-in-out infinite;
  background-image: linear-gradient(
    105deg,
    transparent 0%,
    transparent 40%,
    var(--fallback-b1,oklch(var(--b1)/1)) 50%,
    transparent 60%,
    transparent 100%
  );
  background-size: 200% auto;
  background-repeat: no-repeat;
  background-position-x: -50%;
}

@media (prefers-reduced-motion) {
  .skeleton {
    animation-duration: 15s;
  }
}

@keyframes skeleton {
  from {
    background-position: 150%;
  }

  to {
    background-position: -50%;
  }
}

.tabs-lifted > .tab:focus-visible {
  border-end-end-radius: 0;
  border-end-start-radius: 0;
}

.tab:is(.tab-active, [aria-selected="true"]):not(.tab-disabled):not([disabled]), .tab:is(input:checked) {
  border-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-border-opacity)));
  --tw-border-opacity: 1;
  --tw-text-opacity: 1;
}

.tab:focus {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.tab:focus-visible {
  outline: 2px solid currentColor;
  outline-offset: -5px;
}

.tab-disabled,
  .tab[disabled] {
  cursor: not-allowed;
  color: var(--fallback-bc,oklch(var(--bc)/var(--tw-text-opacity)));
  --tw-text-opacity: 0.2;
}

.tabs-bordered > .tab {
  border-color: var(--fallback-bc,oklch(var(--bc)/var(--tw-border-opacity)));
  --tw-border-opacity: 0.2;
  border-style: solid;
  border-bottom-width: calc(var(--tab-border, 1px) + 1px);
}

.tabs-lifted > .tab {
  border: var(--tab-border, 1px) solid transparent;
  border-width: 0 0 var(--tab-border, 1px) 0;
  border-start-start-radius: var(--tab-radius, 0.5rem);
  border-start-end-radius: var(--tab-radius, 0.5rem);
  border-bottom-color: var(--tab-border-color);
  padding-inline-start: var(--tab-padding, 1rem);
  padding-inline-end: var(--tab-padding, 1rem);
  padding-top: var(--tab-border, 1px);
}

.tabs-lifted > .tab:is(.tab-active, [aria-selected="true"]):not(.tab-disabled):not([disabled]), .tabs-lifted > .tab:is(input:checked) {
  background-color: var(--tab-bg);
  border-width: var(--tab-border, 1px) var(--tab-border, 1px) 0 var(--tab-border, 1px);
  border-inline-start-color: var(--tab-border-color);
  border-inline-end-color: var(--tab-border-color);
  border-top-color: var(--tab-border-color);
  padding-inline-start: calc(var(--tab-padding, 1rem) - var(--tab-border, 1px));
  padding-inline-end: calc(var(--tab-padding, 1rem) - var(--tab-border, 1px));
  padding-bottom: var(--tab-border, 1px);
  padding-top: 0;
}

.tabs-lifted > .tab:is(.tab-active, [aria-selected="true"]):not(.tab-disabled):not([disabled]):before, .tabs-lifted > .tab:is(input:checked):before {
  z-index: 1;
  content: "";
  display: block;
  position: absolute;
  width: calc(100% + var(--tab-radius, 0.5rem) * 2);
  height: var(--tab-radius, 0.5rem);
  bottom: 0;
  background-size: var(--tab-radius, 0.5rem);
  background-position: top left,
        top right;
  background-repeat: no-repeat;
  --tab-grad: calc(69% - var(--tab-border, 1px));
  --radius-start: radial-gradient(
        circle at top left,
        transparent var(--tab-grad),
        var(--tab-border-color) calc(var(--tab-grad) + 0.25px),
        var(--tab-border-color) calc(var(--tab-grad) + var(--tab-border, 1px)),
        var(--tab-bg) calc(var(--tab-grad) + var(--tab-border, 1px) + 0.25px)
      );
  --radius-end: radial-gradient(
        circle at top right,
        transparent var(--tab-grad),
        var(--tab-border-color) calc(var(--tab-grad) + 0.25px),
        var(--tab-border-color) calc(var(--tab-grad) + var(--tab-border, 1px)),
        var(--tab-bg) calc(var(--tab-grad) + var(--tab-border, 1px) + 0.25px)
      );
  background-image: var(--radius-start), var(--radius-end);
}

.tabs-lifted > .tab:is(.tab-active, [aria-selected="true"]):not(.tab-disabled):not([disabled]):first-child:before, .tabs-lifted > .tab:is(input:checked):first-child:before {
  background-image: var(--radius-end);
  background-position: top right;
}

[dir="rtl"] .tabs-lifted > .tab:is(.tab-active, [aria-selected="true"]):not(.tab-disabled):not([disabled]):first-child:before, [dir="rtl"] .tabs-lifted > .tab:is(input:checked):first-child:before {
  background-image: var(--radius-start);
  background-position: top left;
}

.tabs-lifted > .tab:is(.tab-active, [aria-selected="true"]):not(.tab-disabled):not([disabled]):last-child:before, .tabs-lifted > .tab:is(input:checked):last-child:before {
  background-image: var(--radius-start);
  background-position: top left;
}

[dir="rtl"] .tabs-lifted > .tab:is(.tab-active, [aria-selected="true"]):not(.tab-disabled):not([disabled]):last-child:before, [dir="rtl"] .tabs-lifted > .tab:is(input:checked):last-child:before {
  background-image: var(--radius-end);
  background-position: top right;
}

.tabs-lifted
  > :is(.tab-active, [aria-selected="true"]):not(.tab-disabled):not([disabled])
  + .tabs-lifted
  :is(.tab-active, [aria-selected="true"]):not(.tab-disabled):not([disabled]):before, .tabs-lifted > .tab:is(input:checked) + .tabs-lifted .tab:is(input:checked):before {
  background-image: var(--radius-end);
  background-position: top right;
}

.tabs-boxed {
  border-radius: var(--rounded-btn, 0.5rem);
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-bg-opacity)));
  padding: 0.25rem;
}

.tabs-boxed .tab {
  border-radius: var(--rounded-btn, 0.5rem);
}

.tabs-boxed :is(.tab-active, [aria-selected="true"]):not(.tab-disabled):not([disabled]), .tabs-boxed :is(input:checked) {
  --tw-bg-opacity: 1;
  background-color: var(--fallback-p,oklch(var(--p)/var(--tw-bg-opacity)));
  --tw-text-opacity: 1;
  color: var(--fallback-pc,oklch(var(--pc)/var(--tw-text-opacity)));
}

.table:where([dir="rtl"], [dir="rtl"] *) {
  text-align: right;
}

.table :where(th, td) {
  padding-left: 1rem;
  padding-right: 1rem;
  padding-top: 0.75rem;
  padding-bottom: 0.75rem;
  vertical-align: middle;
}

.table tr.active,
  .table tr.active:nth-child(even),
  .table-zebra tbody tr:nth-child(even) {
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-bg-opacity)));
}

.table-zebra tr.active,
    .table-zebra tr.active:nth-child(even),
    .table-zebra-zebra tbody tr:nth-child(even) {
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b3,oklch(var(--b3)/var(--tw-bg-opacity)));
}

.table :where(thead tr, tbody tr:not(:last-child), tbody tr:first-child:last-child) {
  border-bottom-width: 1px;
  --tw-border-opacity: 1;
  border-bottom-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-border-opacity)));
}

.table :where(thead, tfoot) {
  white-space: nowrap;
  font-size: 0.75rem;
  line-height: 1rem;
  font-weight: 700;
  color: var(--fallback-bc,oklch(var(--bc)/0.6));
}

.table :where(tfoot) {
  border-top-width: 1px;
  --tw-border-opacity: 1;
  border-top-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-border-opacity)));
}

.textarea:focus {
  box-shadow: none;
  border-color: var(--fallback-bc,oklch(var(--bc)/0.2));
  outline-style: solid;
  outline-width: 2px;
  outline-offset: 2px;
  outline-color: var(--fallback-bc,oklch(var(--bc)/0.2));
}

.textarea-disabled,
  .textarea:disabled,
  .textarea[disabled] {
  cursor: not-allowed;
  --tw-border-opacity: 1;
  border-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-border-opacity)));
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-bg-opacity)));
  color: var(--fallback-bc,oklch(var(--bc)/0.4));
}

.textarea-disabled::-moz-placeholder, .textarea:disabled::-moz-placeholder, .textarea[disabled]::-moz-placeholder {
  color: var(--fallback-bc,oklch(var(--bc)/var(--tw-placeholder-opacity)));
  --tw-placeholder-opacity: 0.2;
}

.textarea-disabled::placeholder,
  .textarea:disabled::placeholder,
  .textarea[disabled]::placeholder {
  color: var(--fallback-bc,oklch(var(--bc)/var(--tw-placeholder-opacity)));
  --tw-placeholder-opacity: 0.2;
}

@keyframes toast-pop {
  0% {
    transform: scale(0.9);
    opacity: 0;
  }

  100% {
    transform: scale(1);
    opacity: 1;
  }
}

.glass,
  .glass.btn-active {
  border: none;
  -webkit-backdrop-filter: blur(var(--glass-blur, 40px));
          backdrop-filter: blur(var(--glass-blur, 40px));
  background-color: transparent;
  background-image: linear-gradient(
        135deg,
        rgb(255 255 255 / var(--glass-opacity, 30%)) 0%,
        rgb(0 0 0 / 0%) 100%
      ),
      linear-gradient(
        var(--glass-reflex-degree, 100deg),
        rgb(255 255 255 / var(--glass-reflex-opacity, 10%)) 25%,
        rgb(0 0 0 / 0%) 25%
      );
  box-shadow: 0 0 0 1px rgb(255 255 255 / var(--glass-border-opacity, 10%)) inset,
      0 0 0 2px rgb(0 0 0 / 5%);
  text-shadow: 0 1px rgb(0 0 0 / var(--glass-text-shadow-opacity, 5%));
}

@media (hover: hover) {
  .glass.btn-active {
    border: none;
    -webkit-backdrop-filter: blur(var(--glass-blur, 40px));
            backdrop-filter: blur(var(--glass-blur, 40px));
    background-color: transparent;
    background-image: linear-gradient(
          135deg,
          rgb(255 255 255 / var(--glass-opacity, 30%)) 0%,
          rgb(0 0 0 / 0%) 100%
        ),
        linear-gradient(
          var(--glass-reflex-degree, 100deg),
          rgb(255 255 255 / var(--glass-reflex-opacity, 10%)) 25%,
          rgb(0 0 0 / 0%) 25%
        );
    box-shadow: 0 0 0 1px rgb(255 255 255 / var(--glass-border-opacity, 10%)) inset,
        0 0 0 2px rgb(0 0 0 / 5%);
    text-shadow: 0 1px rgb(0 0 0 / var(--glass-text-shadow-opacity, 5%));
  }
}

.artboard.phone {
  width: 320px;
}

.artboard.phone-1 {
  width: 320px;
  height: 568px;
}

.artboard.phone-1.horizontal,
      .artboard.phone-1.artboard-horizontal {
  width: 568px;
  height: 320px;
}

.artboard.phone-2 {
  width: 375px;
  height: 667px;
}

.artboard.phone-2.horizontal,
      .artboard.phone-2.artboard-horizontal {
  width: 667px;
  height: 375px;
}

.artboard.phone-3 {
  width: 414px;
  height: 736px;
}

.artboard.phone-3.horizontal,
      .artboard.phone-3.artboard-horizontal {
  width: 736px;
  height: 414px;
}

.artboard.phone-4 {
  width: 375px;
  height: 812px;
}

.artboard.phone-4.horizontal,
      .artboard.phone-4.artboard-horizontal {
  width: 812px;
  height: 375px;
}

.artboard.phone-5 {
  width: 414px;
  height: 896px;
}

.artboard.phone-5.horizontal,
      .artboard.phone-5.artboard-horizontal {
  width: 896px;
  height: 414px;
}

.artboard.phone-6 {
  width: 320px;
  height: 1024px;
}

.artboard.phone-6.horizontal,
      .artboard.phone-6.artboard-horizontal {
  width: 1024px;
  height: 320px;
}

.btm-nav-xs {
  height: 2.5rem;
}

.btm-nav-xs > *:where(.active) {
  border-top-width: 1px;
}

.btm-nav-xs .btm-nav-label {
  font-size: 0.75rem;
  line-height: 1rem;
}

.btm-nav-sm {
  height: 3rem;
}

.btm-nav-sm > *:where(.active) {
  border-top-width: 2px;
}

.btm-nav-sm .btm-nav-label {
  font-size: 0.75rem;
  line-height: 1rem;
}

.btm-nav-md {
  height: 4rem;
}

.btm-nav-md > *:where(.active) {
  border-top-width: 2px;
}

.btm-nav-md .btm-nav-label {
  font-size: 0.875rem;
  line-height: 1.25rem;
}

.btm-nav-lg {
  height: 5rem;
}

.btm-nav-lg > *:where(.active) {
  border-top-width: 4px;
}

.btm-nav-lg .btm-nav-label {
  font-size: 1rem;
  line-height: 1.5rem;
}

.btn-circle:where(.btn-xs) {
  height: 1.5rem;
  width: 1.5rem;
  border-radius: 9999px;
  padding: 0px;
}

.btn-circle:where(.btn-sm) {
  height: 2rem;
  width: 2rem;
  border-radius: 9999px;
  padding: 0px;
}

.btn-circle:where(.btn-md) {
  height: 3rem;
  width: 3rem;
  border-radius: 9999px;
  padding: 0px;
}

.btn-circle:where(.btn-lg) {
  height: 4rem;
  width: 4rem;
  border-radius: 9999px;
  padding: 0px;
}

.card-side {
  align-items: stretch;
  flex-direction: row;
}

.card-side :where(figure:first-child) {
  overflow: hidden;
  border-start-start-radius: inherit;
  border-start-end-radius: unset;
  border-end-start-radius: inherit;
  border-end-end-radius: unset;
}

.card-side :where(figure:last-child) {
  overflow: hidden;
  border-start-start-radius: unset;
  border-start-end-radius: inherit;
  border-end-start-radius: unset;
  border-end-end-radius: inherit;
}

.card-side figure > * {
  max-width: unset;
}

:where(.card-side figure > *) {
  width: 100%;
  height: 100%;
  -o-object-fit: cover;
     object-fit: cover;
}

.input-md {
  height: 3rem;
  padding-left: 1rem;
  padding-right: 1rem;
  font-size: 0.875rem;
  line-height: 1.25rem;
  line-height: 2;
}

.join.join-vertical {
  flex-direction: column;
}

.join.join-vertical .join-item:first-child:not(:last-child),
  .join.join-vertical *:first-child:not(:last-child) .join-item {
  border-end-start-radius: 0;
  border-end-end-radius: 0;
  border-start-start-radius: inherit;
  border-start-end-radius: inherit;
}

.join.join-vertical .join-item:last-child:not(:first-child),
  .join.join-vertical *:last-child:not(:first-child) .join-item {
  border-start-start-radius: 0;
  border-start-end-radius: 0;
  border-end-start-radius: inherit;
  border-end-end-radius: inherit;
}

.join.join-horizontal {
  flex-direction: row;
}

.join.join-horizontal .join-item:first-child:not(:last-child),
  .join.join-horizontal *:first-child:not(:last-child) .join-item {
  border-end-end-radius: 0;
  border-start-end-radius: 0;
  border-end-start-radius: inherit;
  border-start-start-radius: inherit;
}

.join.join-horizontal .join-item:last-child:not(:first-child),
  .join.join-horizontal *:last-child:not(:first-child) .join-item {
  border-end-start-radius: 0;
  border-start-start-radius: 0;
  border-end-end-radius: inherit;
  border-start-end-radius: inherit;
}

.tabs-md :where(.tab) {
  height: 2rem;
  font-size: 0.875rem;
  line-height: 1.25rem;
  line-height: 2;
  --tab-padding: 1rem;
}

.tabs-lg :where(.tab) {
  height: 3rem;
  font-size: 1.125rem;
  line-height: 1.75rem;
  line-height: 2;
  --tab-padding: 1.25rem;
}

.tabs-sm :where(.tab) {
  height: 1.5rem;
  font-size: 0.875rem;
  line-height: .75rem;
  --tab-padding: 0.75rem;
}

.tabs-xs :where(.tab) {
  height: 1.25rem;
  font-size: 0.75rem;
  line-height: .75rem;
  --tab-padding: 0.5rem;
}

.avatar.online:before {
  content: "";
  position: absolute;
  z-index: 10;
  display: block;
  border-radius: 9999px;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-su,oklch(var(--su)/var(--tw-bg-opacity)));
  outline-style: solid;
  outline-width: 2px;
  outline-color: var(--fallback-b1,oklch(var(--b1)/1));
  width: 15%;
  height: 15%;
  top: 7%;
  right: 7%;
}

.avatar.offline:before {
  content: "";
  position: absolute;
  z-index: 10;
  display: block;
  border-radius: 9999px;
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b3,oklch(var(--b3)/var(--tw-bg-opacity)));
  outline-style: solid;
  outline-width: 2px;
  outline-color: var(--fallback-b1,oklch(var(--b1)/1));
  width: 15%;
  height: 15%;
  top: 7%;
  right: 7%;
}

.card-compact .card-body {
  padding: 1rem;
  font-size: 0.875rem;
  line-height: 1.25rem;
}

.card-compact .card-title {
  margin-bottom: 0.25rem;
}

.card-normal .card-body {
  padding: var(--padding-card, 2rem);
  font-size: 1rem;
  line-height: 1.5rem;
}

.card-normal .card-title {
  margin-bottom: 0.75rem;
}

.join.join-vertical > :where(*:not(:first-child)) {
  margin-left: 0px;
  margin-right: 0px;
  margin-top: -1px;
}

.join.join-vertical > :where(*:not(:first-child)):is(.btn) {
  margin-top: calc(var(--border-btn) * -1);
}

.join.join-horizontal > :where(*:not(:first-child)) {
  margin-top: 0px;
  margin-bottom: 0px;
  margin-inline-start: -1px;
}

.join.join-horizontal > :where(*:not(:first-child)):is(.btn) {
  margin-inline-start: calc(var(--border-btn) * -1);
}

.menu-xs :where(li:not(.menu-title) > *:not(ul, details, .menu-title)), .menu-xs :where(li:not(.menu-title) > details > summary:not(.menu-title)) {
  border-radius: 0.25rem;
  padding-left: 0.5rem;
  padding-right: 0.5rem;
  padding-top: 0.25rem;
  padding-bottom: 0.25rem;
  font-size: 0.75rem;
  line-height: 1rem;
}

.menu-xs .menu-title {
  padding-left: 0.5rem;
  padding-right: 0.5rem;
  padding-top: 0.25rem;
  padding-bottom: 0.25rem;
}

.menu-sm :where(li:not(.menu-title) > *:not(ul, details, .menu-title)), .menu-sm :where(li:not(.menu-title) > details > summary:not(.menu-title)) {
  border-radius: var(--rounded-btn, 0.5rem);
  padding-left: 0.75rem;
  padding-right: 0.75rem;
  padding-top: 0.25rem;
  padding-bottom: 0.25rem;
  font-size: 0.875rem;
  line-height: 1.25rem;
}

.menu-sm .menu-title {
  padding-left: 0.75rem;
  padding-right: 0.75rem;
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
}

.menu-md :where(li:not(.menu-title) > *:not(ul, details, .menu-title)), .menu-md :where(li:not(.menu-title) > details > summary:not(.menu-title)) {
  border-radius: var(--rounded-btn, 0.5rem);
  padding-left: 1rem;
  padding-right: 1rem;
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
  font-size: 0.875rem;
  line-height: 1.25rem;
}

.menu-md .menu-title {
  padding-left: 1rem;
  padding-right: 1rem;
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
}

.menu-lg :where(li:not(.menu-title) > *:not(ul, details, .menu-title)), .menu-lg :where(li:not(.menu-title) > details > summary:not(.menu-title)) {
  border-radius: var(--rounded-btn, 0.5rem);
  padding-left: 1.5rem;
  padding-right: 1.5rem;
  padding-top: 0.75rem;
  padding-bottom: 0.75rem;
  font-size: 1.125rem;
  line-height: 1.75rem;
}

.menu-lg .menu-title {
  padding-left: 1.5rem;
  padding-right: 1.5rem;
  padding-top: 0.75rem;
  padding-bottom: 0.75rem;
}

.visible {
  visibility: visible;
}

.collapse {
  visibility: collapse;
}

.fixed {
  position: fixed;
}

.absolute {
  position: absolute;
}

.relative {
  position: relative;
}

.sticky {
  position: sticky;
}

.isolate {
  isolation: isolate;
}

.z-\[1\] {
  z-index: 1;
}

.float-right {
  float: right;
}

.mx-auto {
  margin-left: auto;
  margin-right: auto;
}

.me-1 {
  margin-inline-end: 0.25rem;
}

.mt-3 {
  margin-top: 0.75rem;
}

.block {
  display: block;
}

.flex {
  display: flex;
}

.table {
  display: table;
}

.grid {
  display: grid;
}

.contents {
  display: contents;
}

.hidden {
  display: none;
}

.h-48 {
  height: 12rem;
}

.h-5 {
  height: 1.25rem;
}

.h-72 {
  height: 18rem;
}

.h-full {
  height: 100%;
}

.w-14 {
  width: 3.5rem;
}

.w-20 {
  width: 5rem;
}

.w-48 {
  width: 12rem;
}

.w-5 {
  width: 1.25rem;
}

.w-52 {
  width: 13rem;
}

.w-96 {
  width: 24rem;
}

.w-full {
  width: 100%;
}

.max-w-2xl {
  max-width: 42rem;
}

.max-w-md {
  max-width: 28rem;
}

.max-w-xs {
  max-width: 20rem;
}

.flex-shrink {
  flex-shrink: 1;
}

.shrink-0 {
  flex-shrink: 0;
}

.flex-grow {
  flex-grow: 1;
}

.border-collapse {
  border-collapse: collapse;
}

.transform {
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.resize {
  resize: both;
}

.flex-wrap {
  flex-wrap: wrap;
}

.items-center {
  align-items: center;
}

.justify-end {
  justify-content: flex-end;
}

.overflow-hidden {
  overflow: hidden;
}

.text-wrap {
  text-wrap: wrap;
}

.rounded-box {
  border-radius: var(--rounded-box, 1rem);
}

.rounded-md {
  border-radius: 0.375rem;
}

.rounded-xl {
  border-radius: 0.75rem;
}

.border {
  border-width: 1px;
}

.border-0 {
  border-width: 0px;
}

.bg-base-100 {
  --tw-bg-opacity: 1;
  background-color: var(--fallback-b1,oklch(var(--b1)/var(--tw-bg-opacity)));
}

.bg-white {
  --tw-bg-opacity: 1;
  background-color: rgb(255 255 255 / var(--tw-bg-opacity));
}

.object-cover {
  -o-object-fit: cover;
     object-fit: cover;
}

.p-2 {
  padding: 0.5rem;
}

.px-10 {
  padding-left: 2.5rem;
  padding-right: 2.5rem;
}

.py-1 {
  padding-top: 0.25rem;
  padding-bottom: 0.25rem;
}

.pt-10 {
  padding-top: 2.5rem;
}

.text-center {
  text-align: center;
}

.text-sm {
  font-size: 0.875rem;
  line-height: 1.25rem;
}

.text-xl {
  font-size: 1.25rem;
  line-height: 1.75rem;
}

.font-medium {
  font-weight: 500;
}

.leading-6 {
  line-height: 1.5rem;
}

.text-gray-900 {
  --tw-text-opacity: 1;
  color: rgb(17 24 39 / var(--tw-text-opacity));
}

.underline {
  text-decoration-line: underline;
}

.antialiased {
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}

.shadow {
  --tw-shadow: 0 1px 3px 0 rgb(0 0 0 / 0.1), 0 1px 2px -1px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 1px 3px 0 var(--tw-shadow-color), 0 1px 2px -1px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.shadow-sm {
  --tw-shadow: 0 1px 2px 0 rgb(0 0 0 / 0.05);
  --tw-shadow-colored: 0 1px 2px 0 var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.shadow-xl {
  --tw-shadow: 0 20px 25px -5px rgb(0 0 0 / 0.1), 0 8px 10px -6px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 20px 25px -5px var(--tw-shadow-color), 0 8px 10px -6px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.outline {
  outline-style: solid;
}

.ring-1 {
  --tw-ring-offset-shadow: var(--tw-ring-inset) 0 0 0 var(--tw-ring-offset-width) var(--tw-ring-offset-color);
  --tw-ring-shadow: var(--tw-ring-inset) 0 0 0 calc(1px + var(--tw-ring-offset-width)) var(--tw-ring-color);
  box-shadow: var(--tw-ring-offset-shadow), var(--tw-ring-shadow), var(--tw-shadow, 0 0 #0000);
}

.ring-inset {
  --tw-ring-inset: inset;
}

.ring-gray-300 {
  --tw-ring-opacity: 1;
  --tw-ring-color: rgb(209 213 219 / var(--tw-ring-opacity));
}

.blur {
  --tw-blur: blur(8px);
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.drop-shadow {
  --tw-drop-shadow: drop-shadow(0 1px 2px rgb(0 0 0 / 0.1)) drop-shadow(0 1px 1px rgb(0 0 0 / 0.06));
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.grayscale {
  --tw-grayscale: grayscale(100%);
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.filter {
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.backdrop-filter {
  -webkit-backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
  backdrop-filter: var(--tw-backdrop-blur) var(--tw-backdrop-brightness) var(--tw-backdrop-contrast) var(--tw-backdrop-grayscale) var(--tw-backdrop-hue-rotate) var(--tw-backdrop-invert) var(--tw-backdrop-opacity) var(--tw-backdrop-saturate) var(--tw-backdrop-sepia);
}

.transition {
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, -webkit-backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter, -webkit-backdrop-filter;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-duration: 150ms;
}

.ease-in-out {
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
}

@media (hover:hover) {
  .table .\*\:hover > *tr:hover,
  .table .\*\:hover > *tr:nth-child(even):hover {
    --tw-bg-opacity: 1;
    background-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-bg-opacity)));
  }

  .table-zebra .\*\:hover > *tr:hover,
  .table-zebra .\*\:hover > *tr:nth-child(even):hover {
    --tw-bg-opacity: 1;
    background-color: var(--fallback-b3,oklch(var(--b3)/var(--tw-bg-opacity)));
  }

  .table .hover\:hover:hovertr:hover,
  .table .hover\:hover:hovertr:nth-child(even):hover {
    --tw-bg-opacity: 1;
    background-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-bg-opacity)));
  }

  .table-zebra .hover\:hover:hovertr:hover,
  .table-zebra .hover\:hover:hovertr:nth-child(even):hover {
    --tw-bg-opacity: 1;
    background-color: var(--fallback-b3,oklch(var(--b3)/var(--tw-bg-opacity)));
  }

  .table .disabled\:hover:disabledtr:hover,
  .table .disabled\:hover:disabledtr:nth-child(even):hover {
    --tw-bg-opacity: 1;
    background-color: var(--fallback-b2,oklch(var(--b2)/var(--tw-bg-opacity)));
  }

  .table-zebra .disabled\:hover:disabledtr:hover,
  .table-zebra .disabled\:hover:disabledtr:nth-child(even):hover {
    --tw-bg-opacity: 1;
    background-color: var(--fallback-b3,oklch(var(--b3)/var(--tw-bg-opacity)));
  }
}

@media (min-width: 768px) {
  .md\:h-full {
    height: 100%;
  }

  .md\:w-48 {
    width: 12rem;
  }

  .md\:max-w-2xl {
    max-width: 42rem;
  }

  .md\:shrink-0 {
    flex-shrink: 0;
  }
}