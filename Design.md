# Design System Inspired by Brother

## 1. Visual Theme & Atmosphere

Brother's design system embodies professional reliability with approachable warmth, serving as the digital extension of a trusted, innovation-focused brand. The visual personality combines deep corporate navy and rich blues with clean, spacious layouts that communicate precision and trustworthiness. The design emphasizes clarity and purpose—every element supports the user's journey from discovery to action. Subtle shadows and generous whitespace create an uncluttered, premium feel, while the consistent use of rounded buttons and smooth interactions convey modern, user-centric thinking. This is a system built for both creative professionals and everyday users, balancing industrial product heritage with accessible, contemporary web experiences.

**Key Characteristics**
- Deep navy foundation with professional blue accents
- Clean, minimal aesthetic with deliberate whitespace
- Generous, rounded button treatments suggest approachability
- High contrast between dark headers and light content areas
- Sophisticated neutral grays create visual hierarchy
- Smooth, performant interactions prioritize user confidence
- Product-focused photography sits comfortably in generous containers

## 2. Color Palette & Roles

### Primary
- **Deep Navy** (`#020920`): Core brand foundation, used extensively in headers, footers, and dominant text; conveys reliability and professionalism
- **Rich Navy** (`#071956`): Slightly lighter navy for secondary emphasis and hover states; maintains brand cohesion

### Accent Colors
- **Bright Blue** (`#0176D3`): Primary call-to-action accent; draws attention to key interactions and supportive UI elements
- **Saturated Royal Blue** (`#0D2EA0`): Deep accent for focus states and linked content; reinforces brand identity
- **Vibrant Primary Blue** (`#1965E1`): Dynamic accent for hover states and active navigation; balances depth with energy

### Interactive
- **Bright Blue CTA** (`#0176D3`): Primary buttons, links, and interactive elements; signals actionability
- **Navy Text Link** (`#020920`): Underlined or standalone links in body content; maintains readability

### Neutral Scale
- **Pure White** (`#FFFFFF`): Primary content background, button backgrounds, card surfaces
- **Off-White** (`#F7F8FA`): Subtle background for sections and containers; provides gentle visual separation
- **Light Gray** (`#E5E7EB`): Fine borders, dividers, and subtle overlays; maintains visual hierarchy
- **Medium Gray** (`#C9C9C9`): Borders, disabled states, and secondary UI; high usage across components
- **Steel Gray** (`#B1B6C4`): Input placeholders and tertiary text
- **Dark Gray** (`#747474`): Secondary body text and reduced-emphasis content
- **Charcoal** (`#5C5C5C`): Alternative dark text for accessibility
- **Deep Charcoal** (`#5E6579`): Muted headings and contextual labels

### Surface & Borders
- **Card Border** (`#E5E7EB`): 1px borders on product cards and contained sections
- **Input Border** (`#939393`): Form field boundaries; visible but unobtrusive
- **Divider Gray** (`#C9C9C9`): Horizontal rules and section separators

### Status & Semantic
- **Black Overlay** (`#000000`): Modal overlays, video controls, and high-contrast overlays (used sparingly)

## 3. Typography Rules

### Font Family
**Primary:** Inter (system font stack: `Inter, -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, sans-serif`)

**Secondary:** Inter (single family system)

### Hierarchy

| Role | Font | Size | Weight | Line Height | Letter Spacing | Notes |
|------|------|------|--------|-------------|----------------|-------|
| Display / H1 | Inter | 36px | 700 | 43.2px | 0px | Hero headlines, page titles |
| Display / H2 | Inter | 54px | 700 | 56px | 0px | Large section headers, campaign text |
| Heading / H3 | Inter | 20px | 700 | 24px | 0px | Category titles, sub-headers |
| Heading / H4 | Inter | 24px | 700 | 28.8px | 0px | Card titles, featured content |
| Heading / H5 | Inter | 13px | 700 | 20px | 0px | Tags, labels, metadata |
| Heading / H6 | Inter | 18px | 700 | 24px | 0px | Section dividers, emphasis text |
| Body Text | Inter | 14px | 400 | 18px | 0px | Primary body copy, descriptions |
| Body Large | Inter | 16px | 400 | 22px | 0px | Input fields, form text |
| Link | Inter | 16px | 600 | 22px | 0px | Navigation links, CTAs |
| Link Small | Inter | 14px | 500 | 18px | 0px | Footer links, secondary navigation |
| Button | Inter | 16px | 500 | 19.2px | 0px | Button text, navigation items |
| Input Placeholder | Inter | 16px | 400 | 23px | 0px | Form input text and placeholders |

### Principles
- **Hierarchy through weight:** Bold (700) for headings, regular (400) for body, semi-bold (600) for links and emphasis
- **Clear reading rhythm:** Generous line heights (1.3–1.5 ratio) reduce cognitive load
- **Consistency:** Single font family ensures professional, cohesive appearance across all contexts
- **Legibility first:** Minimum 14px for body text; input fields at 16px for touch accessibility
- **Contrast:** Dark navy on white achieves WCAG AA+ contrast; links underlined or styled distinctly

## 4. Component Stylings

### Buttons

**Primary Button (Solid CTA)**
- Background: `#0176D3`
- Text Color: `#FFFFFF`
- Font Size: `16px`
- Font Weight: `500`
- Font Family: `Inter`
- Padding: `12px 24px`
- Border Radius: `9999px`
- Border: `0px solid transparent`
- Box Shadow: `none`
- Height: `40px`
- Line Height: `19.2px`
- Hover State: Background `#0D5FA8` (darken 15%)
- Active State: Background `#0D5FA8`, outline `2px solid #0176D3` offset `2px`
- Disabled State: Background `#C9C9C9`, Text Color `#747474`, cursor `not-allowed`

**Secondary Button (Outlined)**
- Background: `rgba(255, 255, 255, 0.1)` (transparent overlay on dark)
- Text Color: `#FFFFFF`
- Font Size: `16px`
- Font Weight: `500`
- Font Family: `Inter`
- Padding: `12px 24px`
- Border Radius: `9999px`
- Border: `2px solid #FFFFFF`
- Box Shadow: `none`
- Height: `40px`
- Line Height: `19.2px`
- Hover State: Background `rgba(255, 255, 255, 0.2)`, Border `2px solid #FFFFFF`
- Active State: Background `rgba(255, 255, 255, 0.3)`
- Disabled State: Background `rgba(255, 255, 255, 0.05)`, Border `2px solid #C9C9C9`, Text Color `#C9C9C9`

**Ghost Button (Text-only)**
- Background: `transparent`
- Text Color: `#020920`
- Font Size: `16px`
- Font Weight: `400`
- Font Family: `Inter`
- Padding: `0px`
- Border Radius: `0px`
- Border: `0px solid transparent`
- Box Shadow: `none`
- Height: `auto`
- Line Height: `22px`
- Hover State: Text Color `#0176D3`, Text Decoration `underline`
- Active State: Text Color `#0D5FA8`
- Disabled State: Text Color `#C9C9C9`, cursor `not-allowed`

**Icon Button (Small, Circular)**
- Background: `transparent`
- Text Color: `#FFFFFF`
- Font Size: `16px`
- Font Weight: `500`
- Font Family: `Inter`
- Padding: `8px`
- Border Radius: `9999px`
- Border: `0px solid transparent`
- Box Shadow: `none`
- Height: `40px`
- Width: `40px`
- Line Height: `19.2px`
- Hover State: Background `rgba(255, 255, 255, 0.1)`
- Active State: Background `rgba(255, 255, 255, 0.2)`
- Disabled State: Background `rgba(255, 255, 255, 0.05)`, cursor `not-allowed`

### Cards & Containers

**Product Card (Standard)**
- Background: `#FFFFFF`
- Text Color: `#444444`
- Font Size: `16px`
- Font Weight: `400`
- Font Family: `Inter`
- Padding: `0px`
- Border Radius: `0px`
- Border: `1px solid #E5E7EB`
- Box Shadow: `none`
- Height: `379px` (auto for responsive)
- Width: `292px`
- Line Height: `22px`
- Hover State: Border Color `#C9C9C9`, Box Shadow `rgba(0, 0, 0, 0.05) 0px 1px 2px 0px`
- Image Container: `100%` width, `240px` height, object-fit `cover`
- Title: `18px` bold, margin-bottom `12px`
- Description: `14px` regular, margin-bottom `16px`

**Content Card (Padded)**
- Background: `transparent`
- Text Color: `#444444`
- Font Size: `16px`
- Font Weight: `400`
- Font Family: `Inter`
- Padding: `20px`
- Border Radius: `0px`
- Border: `0px solid transparent`
- Box Shadow: `none`
- Height: `auto`
- Width: `290px`
- Line Height: `22px`
- Hover State: Background `rgba(0, 0, 0, 0.02)`

**Section Container**
- Background: `#F7F8FA` or `#FFFFFF`
- Border: `0px solid transparent` or `1px solid #E5E7EB`
- Padding: `64px 40px` (desktop), `40px 24px` (tablet), `24px 16px` (mobile)
- Max Width: `1200px` (centered containers)

### Inputs & Forms

**Text Input (Light Theme)**
- Background: `rgba(255, 255, 255, 0.1)`
- Text Color: `#F7F8FA`
- Font Size: `16px`
- Font Weight: `400`
- Font Family: `Inter`
- Padding: `0px 16px 0px 40px` (with icon offset)
- Border Radius: `100px`
- Border: `0px solid transparent`
- Box Shadow: `none`
- Height: `40px`
- Width: `260px`
- Line Height: `23px`
- Placeholder Color: `#B1B6C4`
- Focus State: Background `rgba(255, 255, 255, 0.15)`, outline `2px solid #0176D3` offset `2px`
- Hover State: Background `rgba(255, 255, 255, 0.12)`
- Disabled State: Background `rgba(255, 255, 255, 0.05)`, cursor `not-allowed`

**Text Input (Search Variant)**
- Background: `rgba(255, 255, 255, 0.1)`
- Text Color: `#D4D8DF`
- Font Size: `16px`
- Font Weight: `400`
- Font Family: `Inter`
- Padding: `4px 48px 4px 18px`
- Border Radius: `100px`
- Border: `0px solid transparent`
- Box Shadow: `none`
- Height: `48px`
- Width: `318px` (or `100%` responsive)
- Line Height: `22px`
- Placeholder Color: `#B1B6C4`
- Focus State: Background `rgba(255, 255, 255, 0.15)`, outline `2px solid #0176D3` offset `2px`
- Icon (trailing): `24px` × `24px`, margin-right `12px`, pointer-events `none`

**Form Group (Label + Input)**
- Label: `14px` weight `600`, color `#020920`, margin-bottom `8px`
- Input: `16px` weight `400`, full width responsive
- Error State: Input Border `2px solid #DC2626`, Error Text `12px` weight `500` color `#DC2626`, margin-top `4px`
- Helper Text: `12px` weight `400`, color `#747474`, margin-top `4px`

### Navigation

**Header Navigation**
- Background: `#020920`
- Text Color: `#F7F8FA`
- Font Size: `16px`
- Font Weight: `400`
- Font Family: `Inter`
- Padding: `0px` (links have individual padding)
- Border Radius: `0px`
- Border: `0px solid transparent`
- Box Shadow: `none`
- Height: `40px`
- Width: `auto`
- Line Height: `22px`
- Link Item Padding: `12px 16px`
- Hover State: Text Color `#0176D3`, Background `transparent`
- Active State: Text Color `#0176D3`, Border Bottom `2px solid #0176D3`
- Dropdown Menu: Box Shadow `rgba(0, 0, 0, 0.08) 0px 4px 4px 0px`, Background `#FFFFFF`, Border `0px`

**Breadcrumb Navigation**
- Text Color: `#020920`
- Font Size: `14px`
- Font Weight: `400`
- Separator: `/` color `#C9C9C9`, margin `0px 8px`
- Current Page: Font Weight `600`
- Link Hover: Text Color `#0176D3`

### Links

**Inline Link**
- Text Color: `#020920`
- Font Size: `16px`
- Font Weight: `600`
- Font Family: `Inter`
- Text Decoration: `underline` (optional, context-dependent)
- Hover State: Text Color `#0176D3`
- Active State: Text Color `#0D5FA8`
- Visited State: Text Color `#5C5C5C` (optional)

**Footer Link**
- Text Color: `#FFFFFF`
- Font Size: `14px`
- Font Weight: `500`
- Font Family: `Inter`
- Text Decoration: `none`
- Line Height: `18px`
- Hover State: Text Color `#D4D8DF`, Text Decoration `underline`
- Active State: Text Color `#B1B6C4`

## 5. Layout Principles

### Spacing System

**Base Unit:** `4px`

**Scale:**
- **Micro:** `4px` (icon spacing, tight grouping)
- **Compact:** `8px` (button padding, form field gaps)
- **Small:** `12px` (form label to field spacing)
- **Default:** `16px` (standard padding, margins between inline elements)
- **Medium:** `20px` (card padding, section gaps)
- **Large:** `24px` (component spacing, vertical section rhythm)
- **XL:** `32px` (column gaps, medium section separations)
- **2XL:** `40px` (container padding, section rhythm)
- **3XL:** `48px` (hero section spacing, major section gaps)
- **4XL:** `64px` (large section padding, top-level container margins)
- **5XL:** `80px` (full-screen padding, max breathing room)

**Context Usage:**
- Form fields: `8px` to `12px` gaps
- Card content: `16px` to `20px` padding
- Section containers: `40px` to `64px` padding
- Hero areas: `64px` to `80px` padding

### Grid & Container

**Max Width:** `1200px` (content containers, centered on larger screens)

**Column Strategy:**
- Desktop (1200px+): 12-column grid, `20px` gutters
- Tablet (768px–1199px): 12-column grid, `16px` gutters
- Mobile (320px–767px): 4-column grid, `12px` gutters

**Section Patterns:**
- Full-bleed header: `100vw` width, `#020920` background
- Contained section: `max-width: 1200px`, margin `0 auto`, padding `40px`
- Hero section: Full-bleed background with overlay, centered content max `1200px`
- Product grid: 6 columns (desktop), 3 columns (tablet), 2 columns (mobile)
- Footer: 4-column grid (desktop), 2 columns (tablet), 1 column (mobile)

### Whitespace Philosophy

Brother's layout prioritizes generous whitespace as a design principle, not mere absence of content. Ample breathing room around text, images, and interactive elements reduces cognitive load and elevates the perceived quality of products and services. Key sections are visually isolated with 40–64px vertical margins, allowing the eye to rest and refocus. Card-based layouts maintain consistent internal padding (20px) and external spacing (16px between items), creating a rhythm that feels intentional and organized. Negative space is as important as filled space—empty backgrounds and sparse content areas communicate clarity, confidence, and premium positioning.

### Border Radius Scale

- **Circular:** `9999px` (buttons, icon buttons, pill-shaped inputs)
- **Large Round:** `100px` (search inputs, large form fields)
- **Medium Round:** `50px` (medium inputs, pill buttons)
- **Small Round:** `8px` (minor components, link underlines)
- **None:** `0px` (cards, containers, utilitarian elements)

## 6. Depth & Elevation

| Level | Treatment | Use |
|-------|-----------|-----|
| None | No shadow | Cards, containers, navigation, default components |
| Hover / Interactive | `rgba(0, 0, 0, 0.05) 0px 1px 2px 0px` | Product cards on hover, raised buttons |
| Dropdown / Overlay | `rgba(0, 0, 0, 0.08) 0px 4px 4px 0px` | Dropdown menus, popover containers |
| Modal / Deep Overlay | `rgba(0, 0, 0, 0.06) 0px 4px 16px 0px` | Modal dialogs, cookie consent panels |
| Focus Ring | `2px solid #0176D3` offset `2px` | Input focus, button focus, keyboard navigation |

**Shadow Philosophy:**

Brother's elevation system is intentionally restrained, reflecting a clean, modern aesthetic. Shadows are used sparingly—only to clarify layering or signal interactivity. Small, tight shadows (1–4px blur) indicate minor depth changes (hover states), while medium shadows (4–8px blur) denote significant layering (dropdowns, modals). The shadow color is always black with low opacity (5–8%), maintaining visual harmony with the neutral palette. Avoiding excessive shadows keeps the interface feeling flat and organized, consistent with contemporary web design. Focus rings are always explicit and blue (`#0176D3`) for keyboard users, ensuring accessibility.

## 7. Do's and Don'ts

### Do
- Use the primary navy (`#020920`) as the foundation for all major text and backgrounds
- Apply bright blue (`#0176D3`) exclusively to primary CTAs, links, and interactive hover states
- Maintain at least `16px` line height for all body text; `19.2px` for buttons
- Use rounded buttons (`9999px` border radius) for all call-to-action buttons
- Group related form fields with `12px` vertical spacing and clear labels
- Implement generous padding (`20px+`) inside cards and containers to breathe
- Use `#F7F8FA` as a subtle background for alternating sections
- Ensure all interactive elements have clearly visible focus states (`2px solid #0176D3`)
- Scale typography responsively: reduce heading sizes by 10–20% on mobile
- Use `#C9C9C9` for dividers and non-critical borders; keep them thin (`1px`)

### Don't
- Mix navy and blue accent colors in the same button or link
- Use text smaller than `14px` for body copy; reserve `12px` for captions and metadata only
- Apply box shadows to cards or containers at default state—reserve for hover/interactive states
- Create form fields with border radius greater than `100px` unless pill-shaped
- Render text in light gray (`#B1B6C4`) on white backgrounds; ensure at least `#747474` for contrast
- Overshadow primary content with more than 2 levels of visual hierarchy per section
- Center-align body text; keep it left-aligned for readability
- Use color alone to communicate status—pair with icons, text, or patterns
- Apply multiple box shadows to the same element; use one shadow per depth level
- Forget to include focus states for keyboard users on every interactive element

## 8. Responsive Behavior

### Breakpoints

| Name | Width | Key Changes |
|------|-------|-------------|
| Mobile | 320px–767px | 1 column, `16px` padding, font sizes −10%, full-width cards, hamburger menu |
| Tablet | 768px–1199px | 2–3 columns, `24px` padding, font sizes −5%, optimized touch targets, compact nav |
| Desktop | 1200px+ | 4–6 columns, `40px` padding, full font sizes, horizontal nav, max-width containers |
| Large Desktop | 1920px+ | Same grid, increased max-width padding to `80px`, larger imagery |

### Touch Targets

- **Minimum:** `44px` × `44px` (buttons, links, tappable areas on mobile)
- **Recommended:** `48px` × `48px` (form fields, navigation items)
- **Icon-only buttons:** `40px` × `40px` minimum
- **Spacing between targets:** `8px` minimum to avoid accidental taps
- **Form inputs:** Always `40px+` height; horizontal padding `16px` minimum

### Collapsing Strategy

**Navigation:**
- Desktop: Horizontal navbar with dropdown menus
- Tablet: Compressed horizontal nav with mega-menu on hover
- Mobile: Hamburger icon reveals slide-out drawer with full navigation tree

**Grid Layout:**
- Desktop: 6-column product grid → Tablet: 3-column grid → Mobile: 2-column grid
- Hero section: Full image + text overlay (desktop) → Stacked image above text (tablet/mobile)
- Footer: 4 columns → 2 columns → 1 column

**Typography:**
- H2 `54px` (desktop) → `36px` (tablet) → `28px` (mobile)
- H1 `36px` (desktop) → `28px` (tablet) → `24px` (mobile)
- Body `14px` remains consistent; line height increases to `20px` on mobile for touch readability

**Spacing:**
- Container padding: `40px` (desktop) → `24px` (tablet) → `16px` (mobile)
- Section gaps: `48px` (desktop) → `32px` (tablet) → `24px` (mobile)

**Input & Form:**
- Search bar: `260px` width (desktop) → `200px` (tablet) → `100%` (mobile)
- Button groups: Horizontal (desktop) → Vertical stacked (mobile)

## 9. Agent Prompt Guide

### Quick Color Reference
- **Primary CTA:** Bright Blue (`#0176D3`) — use on all primary buttons, active links, hover states
- **Background (Dark):** Deep Navy (`#020920`) — header, footer, section overlays
- **Background (Light):** Pure White (`#FFFFFF`) or Off-White (`#F7F8FA`) — main content areas
- **Heading Text:** Deep Navy (`#020920`) or Deep Charcoal (`#5E6579`) — hierarchy and emphasis
- **Body Text:** Dark Gray (`#747474`) or Charcoal (`#5C5C5C`) — readable, accessible
- **Borders & Dividers:** Light Gray (`#E5E7EB`) or Medium Gray (`#C9C9C9`) — subtle visual structure
- **Focus / Active State:** Bright Blue (`#0176D3`) with `2px` outline — keyboard navigation, interaction feedback
- **Disabled State:** Medium Gray (`#C9C9C9`) text on Light Gray (`#E5E7EB`) background — reduced interactivity
- **Status / Semantic:** Not primary in current palette; infer from context (error = red, success = green, warning = yellow)

### Iteration Guide

1. **Color First:** Always start with Deep Navy (`#020920`) for text and Bright Blue (`#0176D3`) for interactive elements. Neutral grays (`#C9C9C9`, `#E5E7EB`, `#747474`) for secondary content and borders.

2. **Typography Hierarchy:** Use the extracted scale (H1 `36px`, H2 `54px`, body `14px`). Inter font family, consistent weights (700 bold headings, 400 regular body, 600 semi-bold links). Maintain `1.3`–`1.5` line-height ratio for readability.

3. **Spacing Discipline:** Apply the spacing system (`8px`, `12px`, `16px`, `20px`, `24px`, `32px`, `40px`, `64px`, `80px`). Never create custom spacing; snap to the scale. Use generous padding inside cards (`20px`), tight gaps between form fields (`8px`–`12px`).

4. **Button Treatment:** All primary CTAs use `9999px` border radius, `12px 24px` padding, `#0176D3` background. Secondary buttons add white border `2px`, transparent background. Ghost buttons are text-only with hover underline. Icon buttons stay `40px` × `40px` with `9999px` radius.

5. **Component Elevation:** Cards and containers default to no shadow. Hover states add subtle shadow `rgba(0, 0, 0, 0.05) 0px 1px 2px 0px`. Dropdowns and modals use `rgba(0, 0, 0, 0.08) 0px 4px 4px 0px`. Never stack multiple shadows.

6. **Focus & Accessibility:** Every interactive element must have a focus state: `2px solid #0176D3` outline with `2px` offset. Ensure keyboard navigation is visible and logical. Test color contrast: navy on white = WCAG AA+, body gray on white = WCAG AA minimum.

7. **Responsive Scaling:** Reduce all font sizes by 10% on mobile, 5% on tablet. Collapse grids: desktop 6-col → tablet 3-col → mobile 2-col. Stack navigation into hamburger menu on mobile. Maintain minimum touch targets (`44px` × `44px`).

8. **Form Fields:** Use `100px` border radius for search inputs, `8px` padding, `16px` font size, transparent white overlay background on dark surfaces. Labels always bold (`600` weight), `14px` size, positioned above input with `8px` gap.

9. **Contrast & Readability:** Never use text smaller than `14px` for body. Light gray (`#B1B6C4`) only for placeholders; body text uses `#747474` or darker. Ensure all text meets WCAG AA contrast minimums (4.5:1 for normal text). Use sufficient line-height: body `18px`, button `19.2px`.

10. **Brand Voice in Details:** Rounded buttons and soft shadows communicate "approachable professionalism." Deep navy and bright blue signal "trustworthy expertise." Generous whitespace and minimal borders say "clarity and focus." Every pixel choice reinforces Brother's position as a reliable, modern technology partner.