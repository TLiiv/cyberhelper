import { Box, Button, Text, Heading, Flex } from "@chakra-ui/react";
import { Email, populateEmailBody, sanitizeHtml } from "./Email.helpers";

const EmailPreview: React.FC<{
  selectedEmail: Email;
  onGuess: (isPhishingGuess: boolean) => void;
  isGuessed: boolean;
  guessFeedback: string;
}> = ({ selectedEmail, onGuess, isGuessed, guessFeedback }) => {
  return (
    <>
      <Heading size="xl" fontWeight="semibold">
        {selectedEmail.subject}
      </Heading>
      <Text fontSize="sm" fontWeight="semibold" color="gray.800">
        From: {selectedEmail.sender}
      </Text>
      <Text fontSize="sm" color="gray.500">
        To: user@cybermail.ee
      </Text>
      <Box mt={6} p={4} bg="gray.100" borderRadius="lg">
        <div dangerouslySetInnerHTML={{ __html: selectedEmail.body }} />
        {selectedEmail.displayLink && (
          <Text fontStyle="italic">
            <a href={selectedEmail.hiddenLink}>{selectedEmail.displayLink}</a>
          </Text>
        )}

        {selectedEmail.footer && (
          <Text mt={4} fontSize="sm" color="gray.600">
            {selectedEmail.footer}
          </Text>
        )}

        {selectedEmail.contactNumber && (
          <Text mt={2} fontSize="sm" color="gray.600">
            Contact: {selectedEmail.contactNumber}
          </Text>
        )}

        {selectedEmail.signature && (
          <Text mt={2} fontSize="sm" fontStyle="italic" color="gray.600">
            {selectedEmail.signature}
          </Text>
        )}
      </Box>

      <Box position="absolute" bottom="10%" left="65%">
        <Flex mt={4} direction="column" gap={4}>
          <Flex gap={4}>
            <Button
              colorPalette="teal"
              onClick={() => onGuess(true)}
              disabled={isGuessed}
            >
              Andmepüük
            </Button>
            <Button
              colorPalette="teal"
              onClick={() => onGuess(false)}
              disabled={isGuessed}
            >
              Legitiimne
            </Button>
          </Flex>

          {guessFeedback && (
            <Text fontSize="md" fontWeight="bold" textAlign="center">
              {guessFeedback}
            </Text>
          )}
        </Flex>
      </Box>
    </>
  );
};

export default EmailPreview;
