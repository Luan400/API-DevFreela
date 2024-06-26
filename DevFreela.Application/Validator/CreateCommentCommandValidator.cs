﻿using DevFreela.Application.Commands.CreateComment;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.Validator
{
   public class CreateCommentCommandValidator : AbstractValidator<CreateCommentCommand>
    {

        public CreateCommentCommandValidator() {

            RuleFor(p => p.Content)
                  .MaximumLength(255)
                  .WithMessage("Tamanho máximo de Texto de Comentário é de 255 caracteres.");
        }


    }
}
