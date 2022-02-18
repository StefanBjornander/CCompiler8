﻿namespace CCompiler {
  public enum Message {
    Usage_compiler_filename,
    Keyword_defined_twice,
    Invalid_specifier_sequence,
    Invalid_specifier_sequence_together_with_type,
    Out_of_registers,
    Unfinished_block_comment,
    Invalid_type_cast,
    Newline_in_string,
    Unfinished_string,
    Parse_error,
    Invalid_type,
    Operator_size,
    Newline_in_character,
    Unfinished_character,
    Invalid_hexadecimal_code,
    Invalid_slash_sequence,
    Double_sharps_at_beginning_of_line,
    Double_sharps_at_end_of_line,
    Two_consecutive_double_sharps,
    Only_extern_or_static_storage_allowed_for_functions,
    Only_auto_or_register_storage_allowed_for_struct_or_union_member,
    Function_missing,
    Not_a_function,
    Function_main_must_return_void_or_integer,
    Undefined_parameter_in_old__style_function_definition,
    Unmatched_number_of_parameters_in_old__style_function_definition,
    A_function_must_be_static_or_extern,
    Invalid_parameter_list,
    Undefined_label,
    Unreferenced_label,
    Missing_goto_address,
    Tag_already_defined,
    Tag_not_found,
    Duplicate_symbol,
    Unknown_enumeration,
    Not_an_enumeration,
    Different_return_type_in_function_redeclaration,
    Mixing_variadic_function_parameter_in_redeclaration,
    Different_parameter_lists_in_function_redeclaration,
    Invalid_initialization,
    /*Functions_cannot_be_initialized,
    Typedef_cannot_be_initialized,
    Extern_cannot_be_initialized,
    Struct_or_union_fields_cannot_be_initialized,*/
    Auto_or_register_storage_in_global_scope,
    Name_already_defined,
    Different_types_in_redeclaration,
    Invalid_tag_redeclaration,
    Case_without_switch,
    Non__constant_case_value,
    Repeated_case_value,
    Default_without_switch,
    Repeted_default,
    Break_without_switch____while____do____or____for,
    Continue_without_while____do____or____for,
    Unnamed_function_definition,
    New_and_old_style_mixed_function_definition,
    Non__integral_enum_value,
    Non__constant_enum_value,
    Bitfields_only_allowed_in_structs_or_unions,
    Non__integral_bits_expression,
    Non__integral_case_value, 
    Bits_value_out_of_range,
    Non__positive_array_size,
    Non__constant_expression,
    Not_constant_or_static_expression,
    An_variadic_function_must_have_at_least_one_parameter,
    A_void_parameter_cannot_be_named,
    An_variadic_function_cannot_have_a_void_parameter,
    Invalid_void_parameter,
    Parameters_must_have_auto_or_register_storage,
    If___ifdef____or_ifndef_directive_without_matching_endif,
    Array_of_incomplete_type_not_allowed,
    Array_of_function_not_allowed,
    Function_cannot_return_array,
    Function_cannot_return_function,
    Duplicate_name_in_parameter_list,
    Syntax_error,
    Invalid_octal_sequence,
    Invalid_char_sequence,
    Non__integral_expression,
    Not_assignable,
    /*Invalid_type_in_bitwise_expression,
    Invalid_type_in_shift_expression,*/
    Pointer_to_void,
    Invalid_type_in_expression,
    Invalid_arithmetic_expression,
    Invalid_types_in_addition_expression,
    Invalid_types_in_subtraction_expression,
    Invalid_addition_expression,
    Invalid_subtraction_expression,
    Invalid_unary_expression,
    Invalid_sizeof_expression,
    Invalid_pointer_type_in_addition_expression,
    Different_pointer_sizes_in_subtraction_expression,
    Register_storage_not_allowed_in_sizof_expression,
    Sizeof_applied_to_function_not_allowed,
    Sizeof_applied_to_bitfield_not_allowed,
    Not_addressable,
//    Invalid_address_of_register_storage,
    Invalid_dereference_of_non__pointer,
    Not_a_pointer_in_arrow_expression,
    Not_a_pointer_to_a_struct_or_union_in_arrow_expression,
    Unknown_member_in_arrow_expression,
    Invalid_type_in_increment_expression,
    Not_a_struct_or_union_in_dot_expression,
    Member_access_of_incomplete_struct_or_union,
    Unknown_member_in_dot_expression,
    Invalid_type_in_index_expression,
    Too_few_actual_parameters_in_function_call,
    Too_many_parameters_in_function_call,
    Unknown_name,
    Unknown_name____assuming_function_returning_int,
    Too_many_initializers_in_array,
    Too_many_initializers_in_struct,
    Only_one_Initlizer_allowed_in_unions,
    Duplicate_global_name,
    Missing_external_function,
    Reached_the_end_of_a_non__void_function,
    Floating_stack_overflow,
    Unbalanced_if_and_endif_directive_structure,
    Invalid_line_number,
    Invalid_preprocessor_directive,
    Repeted_include_statement,
    Defined_twice,
    Non__void_return_from_void_function,
    Void_returned_from_non__void_function,
    Invalid_define_directive,
    Invalid_macro_definition,
    Repeated_macro_parameter,
    Mixing_signed_and_unsigned_types,
    Invalid_macro_redefinition,
    Invalid_undef_directive,
    Macro_not_defined,
    Preprocessor_parser,
    Elif_directive_without_preceeding_if____ifdef____or_ifndef_directive,
    Elif_directive_following_else_directive,
    Else_directive_without_preceeding_if____ifdef____or_ifndef_directive,
    Else_directive_after_else_directive,
    Endif_directive_without_preceeding_if____ifdef____or_ifndef_directive,
    Invalid_end_of_macro_call,
    Empty_macro_parameter,
    Empty_macro_parameter_list,
    Invalid_number_of_parameters_in_macro_call,
    Unknown_character,
    Function_missing_in_linking,
    Object_missing_in_linking,
    Non__static_initializer,
    Unnamed_parameter,
    Unknown_register,
    Extern_enumeration_item_cannot_be_initialized,
    Only_array_struct_or_union_can_be_initialized_by_a_list,
    //Unmatched_register_size,
    Value_overflow,
    Invalid_expression,
    String_does_not_fit_in_array,
    Only_auto_or_register_storage_allowed_in_parameter_declaration,
    Only_auto_or_register_storage_allowed_for_struct_or_union_scope,
    Only_extern____static____or_typedef_storage_allowed_in_global_scope,
    Missing_include_path,
    Only_integral_values_for_bitwise_not
  };
}

/*namespace CCompiler {
  public enum Message {
    Keyword_defined_twice,
    Invalid_specifier_sequence,
    Invalid_specifier_sequence_together_with_type,
    Out_of_registers,
    Unfinished_block_comment,
    Invalid_type_cast,
    Newline_in_string,
    Unfinished_string,
    Parse_error,
    Invalid_type,
    //Object_code_switch_default,
    Operator_size,
    Newline_in_character,
    Unfinished_character,
    Invalid_hexadecimal_code,
    Invalid_slash_sequence,
    Double_sharps_at_beginning_of_line,
    Double_sharps_at_end_of_line,
    Two_consecutive_double_sharps,
    Only_static___extern_or_typedef_storage_allowed_for_functions,
    Only_auto_or_register_storage_allowed_for_struct_or_union_member,
    Function_missing,
    Not_a_function,
    Function_main_must_return_void_or_integer,
    Undefined_parameter_in_old__style_function_definition,
    Unmatched_number_of_parameters_in_old__style_function_definition,
    A_function_must_be_static_or_extern,
    Invalid_parameter_list,
    Undefined_label,
    Unreferenced_label,
    Missing_goto_address,
    Tag_already_defined,
    Tag_not_found,
    Duplicate_symbol,
    Unknown_enumeration,
    Not_an_enumeration,
    Different_return_type_in_function_redeclaration,
    Mixing_variadic_function_parameter_in_redeclaration,
    Different_parameter_lists_in_function_redeclaration,
    Functions_cannot_be_initialized,
    Typedef_cannot_be_initialized,
    Extern_cannot_be_initialized,
    Struct_or_union_field_cannot_be_initialized,
    Auto_or_register_storage_in_global_scope,
    Name_already_defined,
    Different_types_in_redeclaration,
    Invalid_tag_redeclaration,
    Case_without_switch,
    Non__constant_case_value,
    Repeated_case_value,
    Default_without_switch,
    Repeted_default,
    Break_without_switch____while____do____or____for,
    Continue_without_while____do____or____for,
    Unnamed_function_definition,
    New_and_old_style_mixed_function_definition,
    Non__integral_enum_value,
    Non__constant_enum_value,
    Bitfields_only_allowed_on_structs,
    Only_auto_or_register_storage_allowed_in_struct_or_union,
    Non__integral_bits_expression,
    Bits_value_out_of_range,
    Non__positive_array_size,
    Non__constant_expression,
    Not_constant_or_static_expression,
    An_variadic_function_must_have_at_least_one_parameter,
    A_void_parameter_cannot_be_named,
    An_variadic_function_cannot_have_a_void_parameter,
    Invalid_void_parameter,
    Parameters_must_have_auto_or_register_storage,
    If___ifdef____or_ifndef_directive_without_matching_endif,
    Array_of_incomplete_type_not_allowed,
    Array_of_function_not_allowed,
    Function_cannot_return_array,
    Function_cannot_return_function,
    Duplicate_name_in_parameter_list,
    Syntax_error,
    Invalid_octal_sequence,
    Invalid_char_sequence,
    Non__integral_expression,
    Not_assignable,
    Invalid_type_in_bitwise_expression,
    Invalid_type_in_shift_expression,
    //Invalid_type_in_equality_expression,
    //Invalid_type_in_relational_expression,
    Pointer_to_void,
    Invalid_type_in_expression,
    Invalid_types_in_addition_expression,
    Invalid_types_in_subtraction_expression,
    Non__arithmetic_expression,
    Register_storage_not_allowed_in_sizof_expression,
    Sizeof_applied_to_function_not_allowed,
    Sizeof_applied_to_bitfield_not_allowed,
    Not_addressable,
    Invalid_address_of_register_storage,
    Invalid_dereference_of_non__pointer,
    Not_a_pointer_in_arrow_expression,
    Not_a_pointer_to_a_struct_or_union_in_arrow_expression,
    Unknown_member_in_arrow_expression,
    Invalid_type_in_increment_expression,
    Not_a_struct_or_union_in_dot_expression,
    Unknown_member_in_dot_expression,
    Invalid_type_in_index_expression,
    Too_few_actual_parameters_in_function_call,
    Too_many_parameters_in_function_call,
    Unknown_name,
    Unknown_name____assuming_function_returning_int,
    Too_many_initializers,
    //Too_few_initializers,
    //A_union_can_be_initializeralized_by_one_value_only,
    Duplicate_global_name,
    //Missing_external_variable,
    Missing_external_function,
    Reached_the_end_of_a_non__void_function,
    Floating_stack_overflow,
    //Integral_set_does_not_equals_track_map_key_set, // XXX
    //Stack_size, // XXX
    //This_target, // XXX
    Unbalanced_if_and_endif_directive_structure,
    Invalid_line_number,
    Invalid_preprocessor_directive,
    Repeted_include_statement,
    Defined_twice,
    Non__void_return_from_void_function,
    Void_returned_from_non__void_function,
    Invalid_define_directive,
    Invalid_macro_definition,
    Repeated_macro_parameter,
    Mixing_signed_and_unsigned_types,
    Invalid_macro_redefinition,
    Invalid_undef_directive,
    Macro_not_defined,
    Preprocessor_parser,
    Elif_directive_without_preceeding_if____ifdef____or_ifndef_directive,
    Elif_directive_following_else_directive,
    Else_directive_without_preceeding_if____ifdef____or_ifndef_directive,
    Else_directive_after_else_directive,
    Endif_directive_without_preceeding_if____ifdef____or_ifndef_directive,
    Invalid_end_of_macro_call,
    Empty_macro_parameter,
    Empty_macro_parameter_list,
    Invalid_number_of_parameters_in_macro_call,
    Unknown_character,
    Function_missing_in_linking,
    Object_missing_in_linking,
    Non__static_initializer,
    Unnamed_parameter,
    Unknown_register,
    Extern_enumeration_item_cannot_be_initialized,
    Only_array_struct_or_union_can_be_initialized_by_a_list,
    Unmatched_register_size,
    Value_overflow,
    Invalid_expression,
    //Declaration_of_incomplete_type
    String_does_not_fit_in_array,
    Only_auto_or_register_storage_allowed_in_parameter_declaration,
    Only_auto_or_register_storage_allowed_for_struct_or_union_scope,
    Only_extern____static____or_typedef_storage_allowed_in_global_scope
  };
}*/