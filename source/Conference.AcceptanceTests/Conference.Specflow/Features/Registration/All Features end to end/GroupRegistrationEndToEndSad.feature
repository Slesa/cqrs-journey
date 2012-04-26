﻿Feature: Registrant workflow for registering a group of Attendees for a conference (sad path)
	In order to register for conference a group of Attendees
	As a Registrant
	I want to be able to select Order Items from one or many available Order Items and make a Reservation

#General preconditions for all the scenarios
Background: 
	Given the list of the available Order Items for the CQRS summit 2012 conference GroupRegE2Esad
	| seat type                        | rate | quota |
	| General admission                | $199 | 2     |
	| Pre-con Workshop with Greg Young | $500 | 2     |
	| Additional cocktail party        | $50  | 2     |


#Initial state	: 3 available items, 2 selected (q=4)
#End state		: 2 reserved and 1 offered waitlisted
Scenario: All the Order Items are available, then some get waitlisted and some reserved
	Given the selected Order Items
	| seat type                 | quantity |
	| General admission         | 2        |
	| Additional cocktail party | 2        |
	And these Seat Types becomes unavailable before the Registrant make the reservation
	| seat type         | quantity |
	| General admission | 1        |
	When the Registrant proceed to make the Reservation			
	Then the Registrant is offered to be waitlisted for these Order Items
	| seat type         | quantity |
	| General admission | 1        |
	And these Order Items should be reserved
	| seat type                 | quantity |
	| General admission         | 1        |
	| Additional cocktail party | 2        |
	And the total should read $299
	And the countdown started


#Seats Allocation pending
@Ignore
Scenario: Allocate some purchased Seats for a group
Given the ConfirmSuccessfulRegistration
And the order access code is 6789
And the Registrant assign the group purchased Seats to attendees as following
	| First name | Last name | email address     | Seat type         |
	| William    | Smith     | William@Smith.com | General admission |
And leave unassigned these individual purchased seats
	| First name | Last name | email address | Seat type                 |
	| Mani       | Kris      | Mani@Kris.com | Additional cocktail party |
Then the Registrant should get a Seat Assignment confirmation
And the Attendees should get an email informing about the conference and the Seat Type with Seat Access Code
	| Access code | email address     | Seat type                        |
	| 6789-1      | William@Smith.com | General admission                |





