        [TestMethod]
        public async Task {repo_name}_FilterBy{field_name}ASC_ReturnValid()
        {
            string paternToFilter = DbContext.{repo_name}.Select(l => l.{field_name}).FirstOrDefault().Substring(1);

            {repo_name}Filter filter = new {repo_name}Filter
            {
                {field_name} = new StringFilter { StartsWith = paternToFilter },
            };

            var result = await repository.Count(filter);
            var expected = await DbContext.{repo_name}.Where(l => l.{field_name}.StartsWith(paternToFilter)).Select(l => l.Id).CountAsync();
            Assert.AreEqual(expected, result);
        }