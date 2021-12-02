# RobotLocator
Robot Locator -  Dwyer Take home

### Instructions to Run

1. Open RobotLocator.sln via Visual Studio
2. Run dotnet restore (to install Newtonsoft.Json package)
3. Run the project
4. Post "Load" JSON payload to https://localhost:7182/api/RobotDistance
5. Verify results

### Future features/functionality
All future features/functionality really requires knowning the requirements of the customer and future needs, but there are some that could prove useful.
1. Add a queueing system where a list of loads can be posted to the back-end and have multiple robots picking up loads simultaneously or potentially even allow robots to drop a load and already have another one they are going to pick up that is close to their destination
2. Add unit tests, particularly concentrating around the within distance and battery level requirement
3. There may eventually need to be a "minimum" battery threshold required so that robots might not fail to deliver their load due to their losing power
4. Robots at battery level zero should likely not be contacted or be sent to a charing station.
5. Submitting updated locations for the robots back to the external API (if the external API allows it) where they end up after dropping off their load