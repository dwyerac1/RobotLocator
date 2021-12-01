# RobotLocator
Robot Locator -  Dwyer Take home

### Instructions to Run

1. Run nuget Restore (to install Newtonsoft.Json package)
2. Run the project
3. Post JSON payload to https://localhost:7182/api/RobotDistance
4. Verify results

### Future features/functionality
All features/functionality really 
1. Add a queueing system where a list of loads can be posted to the back-end and have multiple robots picking up loads simultaneously or potentially even allowing robots to drop a load and already have another one they are going to pick up
2. Add unit tests, particularly concentrating around the within distance and battery level requirement
3. There may eventually need to be a "minimum" battery threshold required so that robots might not fail to deliver their load due to losing power
4. Submitting updated locations for the robots back to the external API (if the external API allows it) when they are dropping their loads