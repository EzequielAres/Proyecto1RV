/******************************************************************************
START Glitch hello-app default styles

The styles in this section do some minimal CSS resets, set default fonts and 
colors, and handle the layout for our footer and "Remix on Glitch" button. If
you're new to CSS they may seem a little complicated, but you can scroll down
to this section's matching END comment to see page-specific styles.
******************************************************************************/


/* 
  The style rules specify elements by type and by attributes such as class and ID
  Each section indicates an element or elements, then lists the style properties to apply
  See if you can cross-reference the rules in this file with the elements in index.html
*/

/* Our default values set as CSS variables */
:root {
  --color-bg: #69F7BE;
  --color-text-main: #000000;
  --color-primary: #FFFF00;
  --wrapper-height: 87vh;
  --image-max-width: 300px;
  --image-margin: 3rem;
  --font-family: "HK Grotesk";
  --font-family-header: "HK Grotesk";
}

/* Basic page style resets */
* {
  box-sizing: border-box;
}
[hidden] {
  display: none !important;
}

/* Import fonts */
@font-face {
  font-family: HK Grotesk;
  src: url("https://cdn.glitch.me/605e2a51-d45f-4d87-a285-9410ad350515%2FHKGrotesk-Regular.otf?v=1603136326027")
    format("opentype");
}
@font-face {
  font-family: HK Grotesk;
  font-weight: bold;
  src: url("https://cdn.glitch.me/605e2a51-d45f-4d87-a285-9410ad350515%2FHKGrotesk-Bold.otf?v=1603136323437")
    format("opentype");
}

/* Our remix on glitch button */
.btn--remix {
  font-family: HK Grotesk;
  padding: 0.75rem 1rem;
  font-size: 1.1rem;
  line-height: 1rem;
  font-weight: 500;
  height: 2.75rem;
  align-items: center;
  cursor: pointer;
  background: #FFFFFF;
  border: 1px solid #000000;
  box-sizing: border-box;
  border-radius: 4px;
  text-decoration: none;
  color: #000;
  white-space: nowrap;
  margin-left: auto;
}
.btn--remix img {
  margin-right: 0.5rem;
}
.btn--remix:hover {
  background-color: #D0FFF1;
}

/* Navigation grid */
.footer {
  display: flex;
  justify-content: space-between;
  margin: 1rem auto 0;
  padding: 1rem 0 0.75rem 0;
  width: 100%;
  flex-wrap: wrap;
  border-top: 4px solid #fff;
}

.footer a:not(.btn--remix):link,
a:not(.btn--remix):visited {
  font-family: HK Grotesk;
  font-style: normal;
  font-weight: normal;
  font-size: 1.1rem;
  color: #000;
  text-decoration: none;
  border-style: none;
}
.footer a:hover {
  background: var(--color-primary);
}

.footer .links {
  padding: 0.5rem 1rem 1.5rem;
  white-space: nowrap;
}

.divider {
  padding: 0 1rem;
}
/******************************************************************************
END Glitch hello-app default styles
******************************************************************************/

body {
  font-family: HK Grotesk;
  background-color: var(--color-bg);
}

/* Page structure */
.wrapper {
  min-height: var(--wrapper-height);
  display: grid;
  place-items: center;
  margin: 0 1rem;
}
.content {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
}

/* Very light scaling for our illustration */
.title {
  color: #2800FF;
  font-family: HK Grotesk;
  font-style: normal;
  font-weight: bold;
  font-size: 100px;
  line-height: 105%;
  margin: 0;
}

/* Very light scaling for our illustration */
.illustration {
  max-width: 100%;
  max-height: var(--image-max-width);
  margin-top: var(--image-margin);
}

/* Instructions */
.instructions {
  margin: 1rem auto 0;
}

/* Button - Add it from the README instructions */
button,
input {
  font-family: inherit;
  font-size: 100%;
  background: #FFFFFF;
  border: 1px solid #000000;
  box-sizing: border-box;
  border-radius: 4px;
  padding: 0.5rem 1rem;
  transition: 500ms;
}

/* Subheading */
h2 {
  color: #2800FF;
}

/* Interactive image */
.illustration:active {
  transform: translateY(5px);
}

/* Button dip
- Toggling this class on and off will move it down and up again
- The button transition property above determines the speed of the translate (500ms)
*/
.dipped {
  transform: translateY(5px);
}
