﻿namespace Orchard.Widgets.SimpleScripting.Compiler {
    public enum TokenKind {
        Eof,
        OpenParen,
        CloseParen,
        StringLiteral,
        SingleQuotedStringLiteral,
        Integer,
        Plus,
        Minus,
        Mul,
        Div,
        True,
        False,
        Identifier,
        And,
        Or,
        Not,
        Invalid
    }
}