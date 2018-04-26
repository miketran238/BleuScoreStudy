	// Reference code
	public void TestParserGrammar() {
		string grammar = "grammar_T;\n" + "options_{output=AST;}\n" + ...
		string found = execParser("T.g", grammar, "TParser", "TLexer", ...;
		Assert.AreEqual("(block_a_b_c)" + NewLine, found);
	}
	// Translated code
	public void TestParserGrammar() {
		string grammar = "grammar_T;\n" + ...;
		string found = execParser("T.g", grammar, ...;
		Assert.AreEqual( < unk > +NewLine, found );
	}
	// Reference code
	public void ContentAppend() {
		if (inText) {
			if (writer.IsTagged()) {
				EndText();
			} else {
				throw new IllegalPdfSyntaxException(MessageLocalization.GetComposedMessage("path.construction.operator.inside.text.object"));
			}
		}
		content.Append(x1).Append(' ').Append(y1)...;
	}
	// Translated code
	public void ContentAppend() {
		if (inText) {
			if (writer.IsTagged()) {
				EndText();
			} else {
				throw new IllegalPdfSyntaxException(MessageLocalization.GetComposedMessage("path.construction.operator.inside.text.object")).Append(font.).Append( < unk > ) .
				Append( < unk > ) .Append( < unk > ) ...
			}
		}
	}