        [TestMethod]
        public async Task {repo_name}_FilterByStartPeriod_ReturnValid()
        {
            {repo_name}Filter filter = new {repo_name}Filter
            {
                StartPeriod = new DateTimeFilter { Greater = new DateTime(2018, 01, 03) },
            };
            var result = await repository.Count(filter);
            var expected = DbContext.{repo_name}.Where(a => a.StartPeriod > new DateTime(2018, 01, 03)).Select(a => a.Id).Count();
            Assert.AreEqual(expected, result);
        }