        [TestMethod]
        public async Task {repo_name}_Filter{field_name}_ReturnValid()
        {
            {repo_name}Filter filter = new {repo_name}Filter
            {
                SetOfBookId = new Guid("02759cdc-d873-4c21-9f84-481b5447f056"),
                BankId = new GuidFilter { Equal = new Guid("a064cbcd-8c22-40dd-b872-7cad19baa12b") }
            };

            var result = await repository.Count(filter);
            var expected = await DbContext.{repo_name}.Where(b => b.SetOfBookId.Equals(new Guid("02759cdc-d873-4c21-9f84-481b5447f056")) && b.BankId.Equals(new Guid("a064cbcd-8c22-40dd-b872-7cad19baa12b"))).Select(b => b.Id).CountAsync();
            Assert.AreEqual(expected, result);
        }