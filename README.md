# PizzaMenuWinForms

![App Screenshot]("C:\Users\ibrah\Programming\General\AbuHadhoud Course\Revision from 01-06-2025\myWindowsFormProject\Pizza_UI.png")

A simple Windows Forms application in C# that lets users build and price their own pizza order. Select size, crust type, toppings, and whether you’ll dine in or take out – then see a live order summary and total price.

## Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Customization & Extension](#customization--extension)
- [Contributing](#contributing)
- [License](#license)

## Features

- **Size Selection**: Small, Medium, or Large pizzas with built-in pricing.
- **Crust Options**: Thin or Thick crust, each with its own tag-based price.
- **Toppings**: Choose from Extra Cheese, Mushrooms, Tomatoes, Onions, Olives, Green Peppers.
- **Dine-In vs Take-Out**: Toggle order context, and see it reflected in the summary.
- **Live Summary Panel**: Automatically updates the list of selections and total cost.
- **Order & Reset**: Finalize your order or clear the form with dedicated buttons.

## Prerequisites

- Windows 10 or later
- [.NET Framework 4.7.2](https://dotnet.microsoft.com/download/dotnet-framework/net472)
- [Visual Studio 2019/2022 Community (or higher)](https://visualstudio.microsoft.com/) with **.NET desktop development** workload

## Getting Started

1. **Clone the repository**:

   ```bash
   git clone https://github.com/IbrahimAlShakak/PizzaMenuWinForms.git
   cd PizzaMenuWinForms
   ```

2. **Open in Visual Studio**:

   - Double‑click on `myWindowsFormProject.sln` or use **File → Open → Project/Solution**.

3. **Restore NuGet Packages** (if prompted).

4. **Build & Run**:

   - Press **F5** or click **Start** to launch the app.

## Usage

1. In the **Size** panel, pick one option – prices are set via each RadioButton's `Tag` property.
2. Under **Crust Type**, choose Thin or Thick.
3. Check any **Toppings** you want; each adds its tag-based price.
4. Select **Dine In** or **Take Out**.
5. Watch the **Order Summary** panel update in real time, including the **Total Price** in bright green.
6. Click **Order Pizza** to lock and confirm (disables form) or **Reset Form** to start over.

## Project Structure

```plaintext
PizzaMenuWinForms/           # Solution root
├── .gitignore               # Git exclusions (bin/, obj/, .vs/)
├── README.md                # Project documentation (this file)
├── myWindowsFormProject.sln # Visual Studio solution
├── myWindowsFormProject/    # WinForms project folder
│   ├── Program.cs           # Application entry point
│   ├── mainForm.cs          # UI logic and event handlers
│   ├── mainForm.Designer.cs # Auto-generated layout code
│   ├── Resources.Designer.cs# Image and string resources
│   ├── Settings.Designer.cs # User settings
│   └── Properties/          # Assembly metadata
└── screenshots/             # Images for README
    └── new_pizza_ui.png
```

## Customization & Extension

- **Add New Toppings**: In the Designer, drop in a new CheckBox, set its text and `Tag` to the price, and wire its `CheckedChanged` event to `UpdateToppings()`.
- **External Configuration**: Refactor to load sizes/crust/toppings from a JSON or XML file instead of hard-coded tags.
- **Persistence**: Save orders to a local database or file for history/analytics.
- **UI Polish**: Use `TableLayoutPanel` for responsive resizing, add icons or pizza images next to each topping.

## Contributing

Contributions are welcome! To propose enhancements or fixes:

1. Fork this repository.
2. Create a feature branch (`git checkout -b feature/YourFeature`).
3. Commit your changes (`git commit -m "Add feature XYZ"`).
4. Push to your branch (`git push origin feature/YourFeature`).
5. Open a Pull Request against `main`.

Please ensure your code is well-documented and follows C# coding conventions.

## License

This project is licensed under the [MIT License](LICENSE). Feel free to use, modify, and distribute as you like.
