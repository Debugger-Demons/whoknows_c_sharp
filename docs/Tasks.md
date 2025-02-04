# MVP Tasks for WhoKnows C# Migration

## 1. Project Setup & Infrastructure
- [x] Initialize ASP.NET Core Web API project
- [x] Set up basic project structure
- [x] Copy over SQLite database
- [ ] Configure SQLite connection
- [ ] Set up basic error handling middleware
- [ ] Configure logging

## 2. Data Layer
- [x] Analyze existing schema.sql
- [x] Create C# models based on SQLite schema
- [x] Set up Entity Framework DbContext
- [ ] Test database connectivity
- [ ] Implement data access layer

## 3. Core Search Functionality
- [ ] Analyze legacy search implementation in app.py
- [ ] Implement basic search endpoint
- [ ] Add search result ranking/scoring
- [ ] Add search filters (if present in legacy)
- [ ] Test search functionality

## 4. API Development
- [ ] Define API endpoints based on legacy routes
- [ ] Implement search API endpoint
- [ ] Add API documentation (Swagger)
- [ ] Add basic rate limiting
- [ ] Add basic caching

## 5. Frontend/Templates Migration
- [ ] Assess legacy templates
- [ ] Convert templates to Razor Pages/MVC
- [ ] Implement basic search UI
- [ ] Style search results page
- [ ] Add basic error pages

## 6. Testing
- [ ] Set up unit testing project
- [ ] Migrate relevant tests from app_tests.py
- [ ] Add integration tests for search
- [ ] Add API endpoint tests
- [ ] Test database operations

## 7. Documentation
- [ ] Update README.md
- [ ] Document API endpoints
- [ ] Document search algorithm
- [ ] Add setup/installation guide
- [ ] Document known limitations

## Priority Features from Legacy
- [ ] Basic search functionality
- [ ] Results ranking
- [ ] Web interface
[To be expanded based on legacy app analysis]

## Notes
- Focus on core search functionality first
- Maintain compatibility with existing database
- Prioritize API stability for future development
