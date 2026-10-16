# Aetheria Network — Minecraft Server Rank Store

A polished, desktop-focused e-commerce web application for a fictional Minecraft server network, built with **C# Blazor Web App (.NET 8)** and **Tailwind CSS**.

---

## 1. Project Overview

Aetheria Network is an original, gaming-inspired Minecraft rank store concept. Players can browse fictional server tiers, view detailed perks, compare tier matrices, and experience a full simulated purchase journey.

- **Fictional Server Identity:** Aetheria Network (`play.aetheria.net`) — high-fantasy RPG and Skyblock realms.
- **Frontend & App Logic:** C# Blazor Web App (.NET 8) with zero custom JavaScript.
- **Render Mode:** `InteractiveServer` applied globally across all routes.
- **Styling:** Custom Tailwind CSS dark gaming palette with committed compiled CSS.

---

## 2. Prerequisites

- **.NET 8 SDK** (Version `8.0.400` or later)
- *(Optional for modifying styles)* **Node.js** (v18+) and **npm** to rebuild Tailwind CSS. The compiled CSS is pre-built and committed into `wwwroot/app.css`, so `dotnet run` works directly on a fresh clone without Node.js.

---

## 3. How to Run

1. Clone or open the repository directory:
   ```bash
   cd MCB2B
   ```
2. Run the application:
   ```bash
   dotnet run
   ```
3. Open your browser and navigate to the local URL displayed in the console (typically `http://localhost:5000` or `https://localhost:5001`).

---

## 4. How to Rebuild Tailwind CSS

The compiled stylesheet (`wwwroot/app.css`) is committed to the repository. If you modify Razor templates or `./Styles/input.css`, rebuild the stylesheet using npm:

1. Install dependencies:
   ```bash
   npm install
   ```
2. Build minified CSS:
   ```bash
   npm run build:css
   ```
3. Or run the auto-rebuilding watcher during development:
   ```bash
   npm run watch:css
   ```

---

## 5. Pre-Seeded Demo Account

The application includes a pre-seeded demo account configured in the in-memory account store:

- **Username:** `demo` (or email: `demo@aetheria.net`)
- **Password:** `demo123`

*Hint: The demo account credentials are also displayed on the Login page (`/login`) for convenience.*

---

## 6. Architecture & State Management

### Global Interactive Server Render Mode
Configured in `Components/App.razor`:
- `<HeadOutlet @rendermode="InteractiveServer" />`
- `<Routes @rendermode="InteractiveServer" />`

All Razor components and pages execute in an interactive server circuit over WebSockets with standard C# event handlers, data binding, and component re-rendering.

### Services
1. **`AccountStore` (`Singleton`):**
   - Holds registered player accounts in a thread-safe `ConcurrentDictionary` during application runtime.
   - Survives browser page refreshes so registered accounts can sign in again as long as the application process runs.
   - Pre-seeded with the `demo` user.
   - Stores account credentials in-memory for demonstration purposes.

2. **`SessionState` (`Scoped`):**
   - Manages the currently logged-in user for the active Blazor circuit.
   - Persists seamlessly across client-side page navigation within the session.
   - Fires an `OnChange` event to notify layouts and components upon login, logout, and profile edits.
   - **Reset on full browser refresh** (F5 / hard reload) as it lives within the scoped circuit connection.

### Core Components & Pages (6 Required Routes)
- **`Layout/MainLayout.razor` & `NavMenu.razor`:** Dark obsidian shell with dynamic auth navigation (login/register when logged out; dashboard/profile/logout when logged in) and persistent demo disclaimer footer.
- **`Components/RankCard.razor`:** Reusable card component displaying rank tier badges, perks, price, "View Details", and "Buy Now".
- **`Components/RankComparison.razor`:** Matrix comparing all 6 tiers across waypoints, coin boosters, flight, ender vaults, and queue priority.
- **`Components/RankModal.razor`:** Single-route 3-step modal on `/store`:
  - **Step 1 (Details):** Full rank description, privileges, and action button.
  - **Step 2 (Confirmation):** Order summary with recipient user and total price.
  - **Step 3 (Success):** Simulated order reference (`ORD-XXXXXX`) and transaction details.
- **Routes:**
  1. `/` (`Home.razor`): Server hero banner, live player count simulation, featured ranks, and community highlights.
  2. `/store` (`Store.razor`): Complete 6-tier catalog, comparison table, and modal purchase flow.
  3. `/login` (`Login.razor`): Validated login form, demo credentials hint, and redirect handler.
  4. `/register` (`Register.razor`): Validated registration with password matching, duplicate check, and automatic login.
  5. `/dashboard` (`Dashboard.razor`): Authenticated user dashboard with personalized greeting and recommended tiers.
  6. `/profile` (`Profile.razor`): Authenticated profile screen with in-memory username and email editor updating session state reactively.

---

## 7. Fictional Rank Catalog

| Rank | Price (USD) | Prefix | Key Perks |
| :--- | :--- | :--- | :--- |
| **Scout** | $4.99 | `[SCOUT]` | 2x Homes, `/hat`, `/workbench`, Priority Queue |
| **Knight** | $9.99 | `[KNIGHT]` | 5x Homes, Keep EXP on Death, 3 Vaults, 1.25x Coins |
| **Vanguard** | $19.99 | `[VANGUARD]` | 10x Homes, Hub `/fly`, Particle Trails, 1.5x Coins |
| **Overlord** | $34.99 | `[OVERLORD]` | 20x Homes, Join Broadcast, All Morphs, 2.0x Coins |
| **Mythic** | $54.99 | `[MYTHIC]` | Unlimited Homes, Private Realms, Sign Colors, 3.0x Coins |
| **Celestial** | $89.99 | `[CELESTIAL]` | Max Island 250x250, `/nick`, Personal Time/Weather, 4.0x Coins |

---

## 8. Suggested Demo Walkthrough

1. **Explore Landing (`/`):** View the server hero, live server status indicator, community highlights, and featured tiers.
2. **Browse Store as Logged-Out Guest (`/store`):**
   - Click **"View Details"** on *Vanguard* to view Step 1 of the modal.
   - Click **"Proceed to Purchase"** or click **"Buy Now"** from any rank card. Observe automatic redirection to `/login` with the message stating login is required.
3. **Log In (`/login`):**
   - Use the pre-seeded credentials `demo` / `demo123` (or click Register to create a new account).
   - Click **"Sign In"**; automatically navigates to `/dashboard`.
4. **Player Dashboard (`/dashboard`):**
   - Review personalized greeting: *"Welcome, demo!"*.
   - Click **"Browse Store"** to return to the catalog.
5. **Purchase Rank (`/store`):**
   - Click **"Buy Now"** on *Celestial* ($89.99).
   - Modal opens directly to **Step 2: Order Confirmation Summary**.
   - Review the order details, recipient account, and simulated transaction notice.
   - Click **"Confirm Purchase"**.
   - Review **Step 3: Order Completed** with generated order reference (e.g. `ORD-8K3N9X`).
   - Click **"Return to Store"**.
6. **Edit Profile (`/profile`):**
   - Click **"Profile"** in the top navigation.
   - Note the unlocked rank badge and user details.
   - Change your username or email in the edit form and click **"Save Profile Changes"**.
   - Notice the header user badge and greeting immediately reflect the new name.
7. **Log Out:**
   - Click **"Logout"** in the top navbar.
   - The session is cleared, and you are safely redirected back to the Landing page (`/`).

---

## 9. Demonstration Limitations & Disclaimers

- **In-Memory Demonstration Only:** All accounts and session states are stored in-memory in C# collections.
- **Session Reset on Refresh:** Scoped session state exists within the Blazor circuit. Hard refreshing the browser terminates the circuit and clears active session state. Registered accounts persist in the singleton store and can be logged back into.
- **No Real Payments:** No credit cards are charged, no payment gateway APIs are contacted, and no money is exchanged.
- **No Minecraft Server Connectivity:** Ranks and perks are simulated for sprint review. This application is not affiliated with or endorsed by Mojang AB or Microsoft.
