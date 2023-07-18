# Power Platform for Pro Developers Sample

This is a demo repository to showcase scenarios where Professional Developers (AKA code-first developers) can make use of Power Platform to be more productive and/or innovative.

To get a free Power Platform environment, sign up for the [developer plan](https://aka.ms/PowerAppsDevPlan).

## Scenario

This is a HVAC company, where they have a legacy inventory management system.
When in appointments, field technicians don't have a way to check if a given part is available in a warehouse. 

They have to manually call each warehouse to check in their legacy internal system.

The back-end developer built an API to get the list of items and the inventory on hand for each warehouse and now she/he wants to build a phone app for the field technicians.

The back-end developer uses Visual Studio and will now use Power Platform to build a phone app to the field technicians.

## Components

1. [InventoryAPI](https://github.com/marcelbf/InventAPI/tree/master/InventAPI) - Visual Studio Project with a sample API with three operations: GetWarehouses, GetItems and GetInventOnHand;
2. [InventoryOnHand](https://github.com/marcelbf/InventAPI/tree/master/InventAPI/InventoryOnHand) - Power Platform Solution with source code for a Custom Connector created from Visual Studio, and a Phone App.
3. [Github Power Platform Action](https://github.com/marcelbf/InventAPI/blob/master/.github/workflows/export-and-commit-solution.yml) - Github action to export the source code of Power Platform Solution created in a Dev Environment.
4. [Web app using PowerFx](https://github.com/marcelbf/InventAPI/tree/master/Power%20Fx%20Demo) - Sample application consuming the InventoryAPI, to show case how to use Power Fx to enable low code scenarios for your users.


