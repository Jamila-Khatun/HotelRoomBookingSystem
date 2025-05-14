# HotelRoomBookingSystem
Overview
A Windows-based hotel management system developed in C# for handling room reservations, client information, and staff management. This desktop application provides an efficient way to manage hotel operations with a local database backend.

Features:

-Authentication Module
-Secure login system with password hashing

Role-based access (Admin, Receptionist, Manager):

Client Management:
-CRUD operations for guest information
_Guest history tracking
_ID/document scanning support

Staff Management:
-Employee record management
Role assignment
-Contact information storage

Room Management:
-Room inventory with status tracking
-Room type classification (Standard, Deluxe, Suite)
-Maintenance scheduling

Reservation System:
-Booking creation and modification
-Check-in/check-out processing
-Availability calendar

Room assignment with visual indicators:

-Technical Specifications
-Development Environment
-Developed in C# (.NET Framework/WPF or Windows Forms)

Database: SQL Server LocalDB/MS Access

ORM: Entity Framework/Dapper

System Requirements:
-Windows 10/11
-.NET Framework 4.7.2 or higher
-Minimum 4GB RAM

Run the Application:
-Open the solution in Visual Studio
-Build and run the project

Usage Guide
Login:
-Use provided credentials (admin/admin for first-time use)
-Change default password immediately

Dashboard:
-Quick access to all modules
-Today's reservations overview

Making a Reservation:
-Navigate to Reservations → New Booking
-Select dates and room type
-Assign to available room
-Save guest information
