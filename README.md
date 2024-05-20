E-Commerce Backend API


Overview

This project is an ASP.NET Core Web API for an e-commerce platform. It provides various endpoints for user authentication, product management, cart operations, and order processing. The API follows an N-Tier architecture and uses JWT for authentication.

Features


User authentication using JWT

CRUD operations for products

Cart management (add, remove, edit items)

Order placement and order history retrieval

Image upload functionality for products

CORS enabled for cross-origin request


Getting Started


Clone the Repository
Copy code

git clone https://github.com/IslamNassar1029/E-commerceAPI.git

cd E-commerceAPI



API Endpoints

Authentication


POST /api/Users/register: Register a new user

POST /api/Users/Login: Authenticate and get a JWT

Products


GET /api/Products/GetProductsWithFilter: Retrieve all products, optionally filter by category and name

GET /api/Products/GetProductWithDetails/{id}: Retrieve product details by ID

POST /api/Products/AddProduct: Add a new product (Admin only)

PUT /api/api/Products/EditProduct: Update an existing product (Admin only)

DELETE /api/Products/DeleteProduct{id}: Delete a product (Admin only)

Cart


POST /api/Carts/AddProduct: Add an item to the cart

DELETE /api/Carts/DeleteCart/{productId}: Remove an item from the cart

PUT /Carts/updateProduct: Edit item quantity in the cart

Orders


POST /api/Orders/AddOrder: Place a new order

GET /api/Orders/OrderHistory: Retrieve order history

Images


POST /api/Files: Upload an image to static files and return the URL of the uploaded image.

Video Demonstration
A video demonstration showcasing the testing of all endpoints using Postman can be accessed here.
This video provides a comprehensive overview of the API functionality, including user authentication, product management, cart operations, and order processing.

https://drive.google.com/file/d/1bQPMNqQTgs-Y9LHimKxGCKqkGHUfgKz8/view?usp=sharing





