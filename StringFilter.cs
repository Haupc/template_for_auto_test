        /**
         * String filter
         * Require: 
         */
        [TestMethod]
        public async Task {repo_name}_Count_FilterBy{field_name}()
        {
            {repo_name}Filter filter = new {repo_name}Filter
            {
                {field_name} = new StringFilter { Equal = /** Insert data overthere */ }
            };

            var result = await repository.Count(filter);
            var expected = await DbContext.{repo_name}
                .Where(c => c.{field_name}, filter.{field_name})
                .Select(c => c.{field_name})
                .CountAsync();

            Assert.AreEqual(expected, result);
        }