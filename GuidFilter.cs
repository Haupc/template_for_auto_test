        [TestMethod]
        public async Task {repo_name}_ListFilterBy{filter_field}_ReturnTrue()
        {
            {repo_name}Filter filter = new {repo_name}Filter
            {
                {filter_field} = new GuidFilter { Equal = CreateGuid(/** code patern */) },
            };

            var result = await repository.List(filter);
            var listCodes = string.Join(",", result.Select(r => r.Code));
            var expected = await this.DbContext.{repo_name}.Where(c => c.{filter_field}.Equals(/** code patern */))
                                                           .OrderBy(c => c.Code)
                                                           .Select(c => c.Code)
                                                           .Skip(0).Take(10)
                                                           .ToListAsync();
            Assert.AreEqual(listCodes, string.Join(",", expected));
        }