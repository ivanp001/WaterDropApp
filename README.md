# WaterDropApp
WaterDropApp UI shows customers info, presenting full list to overview all customers in a list, this app can show Values, can be added for different customers, with its own parameters, Customer`s data can be updated and deleted and can have one or more values connected to its name.

## Technologies Used
* EntityFrameworkCore
* EntityFrameworkCore.InMemory
* BlazorServer
* Bootstrap

## Using The App
1. When the application lanches, it should look like this:
<img width="1365" height="620" alt="Customers List" src="https://github.com/user-attachments/assets/41d99b30-39c9-4f9d-94ec-62fe0ae6f29b" />

2. In Customers List page can be seen all customers after creating, without any acton available:

<img width="1365" height="641" alt="Customers List" src="https://github.com/user-attachments/assets/a5d0edd9-6574-4e9d-9cc0-360be1ce83ef" />

3. In Customers Details can be created New Customers, and see available actions for the selected customer:
<img width="1354" height="688" alt="Customers Details with added customers" src="https://github.com/user-attachments/assets/d0f1e28f-7321-4bd5-8fad-c12e08e9a628" />

4. On Update Customer section can be seen current values for the selected customer and add different to be updated with:
<img width="1363" height="544" alt="Screenshot_109" src="https://github.com/user-attachments/assets/be060cfb-8a9d-4cae-944d-102c123fb253" />

5. On Delete button, customer can be just deleted without any messages or checks.(Upcomming Changes)

6. In Values List can be seen all values for the selected customer, without any action:
<img width="1361" height="503" alt="Screenshot_108" src="https://github.com/user-attachments/assets/1c15c4ea-df6c-4efd-8b13-9e9b022f7ac9" />

7. In Values Details can be added new value for the selected customer, and see existing values:
<img width="1365" height="711" alt="Values for Customer 2" src="https://github.com/user-attachments/assets/40a132dc-8dc3-4c87-ab52-5883c8eab8a1" />


## Upcomming Changes
* Phase 1:
- [x] Create UI components
- [x] In-memory DB, properties and tables
- [x] Customer Service
- [x] Value Service 
* Phase 2:
- [ ] Add checks for inputs
- [ ] Add checks and messages for actions (Update/Delete/Create)
- [ ] Add this app to Docker container
- [ ] Add charts to show consumption statistics for values.
- [ ] Add filtering for customers
- [ ] Add unit tests
- [ ] Seeding
* Phase 3:
- [ ] Create an API so can be connected to different UIs
- [ ] Build and connect to SQL DB

