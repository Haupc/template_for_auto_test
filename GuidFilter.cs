        [TestMethod]
        public async Task {repo_name}_ListFilterBy{Guid_filter_field}_ReturnTrue()
        {
            {repo_name}Filter filter = new {repo_name}Filter()
            {
                // require_field = CreateGuid(code) (1)
                {Guid_filter_field} = new GuidFilter() { Equal = CreateGuid(/** string patern */) }, //(2)
                Skip = 0,
                Take = 10
            };
            var result = await repository.List(filter);
            var listCodes = string.Join(",", result.Select(r => r.Code));
            var expected = await this.DbContext.{repo_name}.Where(c => c.{Guid_filter_field}.Equals(/** //(2) */) && c.{require_field}.Equals(/** Guid of require_field (1) */))
                                                           .OrderBy(c => c.Code)
                                                           .Select(c => c.Code)
                                                           .Skip(0).Take(10)
                                                           .ToListAsync();
            Assert.AreEqual(listCodes, string.Join(",", expected));
        }
