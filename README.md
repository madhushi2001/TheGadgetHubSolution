The Gadget Hub

Project Overview
The Gadget Hub is an online platform that sells the latest gadgets.  
The company does not hold inventory but works with three distributors:
- TechWorld
- ElectroCom
- Gadget Central

When a customer places an order, Gadget Hub:
1. Requests quotations from all distributors.
2. Compares prices and availability.
3. Places the order with the best option.
4. Notifies the customer about the confirmation and delivery time.

This project is developed using Service-Oriented Architecture (SOA/SOC) with .NET Core Web API services and a client application.

 Architecture
The solution is designed with multiple independent services:

- CustomerAPI – Handles order placement from the customer.
- QuotationAPI – Sends quotation requests to all distributors.
- DistributorAPI – Simulates external distributors (TechWorld, ElectroCom, Gadget Central).
- OrderManagementAPI – Compares quotations and places final orders.
- NotificationAPI – Notifies customers via email/SMS (mocked for now).

 High-Level Design
[Customer] ---> [CustomerAPI]
                     |
              [QuotationAPI] ----> [TechWorldAPI]
                                   [ElectroComAPI]
                                   [GadgetCentralAPI]
                     |
              [OrderManagementAPI]
                     |
              [NotificationAPI] ---> [Customer]

 Technologies Used
- .NET 7 / .NET 8 (ASP.NET Core Web API)
- Swagger / OpenAPI for API documentation
- xUnit for testing
- Docker (optional deployment)
- Kubernetes (optional scaling)

## Getting Started
1. Clone this repository:
   ```bash
   git clone https://github.com/yourusername/gadgethub-soc.git
