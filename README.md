# App3H5
Cross-platform mobile app
Level: user-goal
Primary Actor: user

Stakeholders and Interests:
===========================
- User wants to open app 
- User wants to see list of past entries (send /received conversations)
- User wants to have option to create new sms
- User wants to have option to choose from contacts or write it self
- User wants to see chosen contact as recipient
- user wants see where he should write text message
- User should have option to press button to send sms
- User wants to see status of sms processing
- User wants to have searching filters to navigate across sms entries
- User wants to adjust screen settings : light / dark mode
- Application should perform backup ad adat into the external db 
- Backup should be implemented with all security

Success Guarantee (or Postcondition):
====================================
An application that can perform basic messaging functions, with performing of the data back into  the external db.

Main Success Scenario (or Basic Flow):
=====================================
- User open app
- User see empty table or populated with data
- If entries exist - user can open and read conversation
- User can create new sms via pressing + button
- User choosin contact / inputs it self
- User writes for at least one character 
- User presses send button
- User can change setting light/dark mode
